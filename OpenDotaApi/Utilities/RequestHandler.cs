using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OpenDotaApi.Utilities
{
    public sealed class RequestHandler : IDisposable
    {
        private bool _disposed;

        private readonly HttpClientHandler _handler;
        private readonly HttpClient _client;
        private DateTime _lastDateRequest;

        private DateTime LastDateRequest
        {
            get => _lastDateRequest;
            set
            {
                if (value > _lastDateRequest)
                    _lastDateRequest = value;
            }
        }

        public int? CurrentLimitMonth { get; private set; }
        public int? CurrentLimitMinute { get; private set; }
        public string ApiKey { get; set; }

        public RequestHandler(string apiKey = null, IWebProxy proxy = null)
        {
            ApiKey = apiKey;
            _handler = new HttpClientHandler {UseProxy = proxy != null, Proxy = proxy};
            _client = new HttpClient(_handler)
            {
                BaseAddress = new Uri("https://api.opendota.com/api/")
            };
        }

        public async Task<HttpResponseMessage> GetResponseAsync(string url, string parameters = null)
        {
            var useApiKey = true;
            while (true)
            {
                if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));

                if (useApiKey && !string.IsNullOrEmpty(ApiKey)) parameters += $"api_key={ApiKey}";

                url += "?" + parameters;

                HttpResponseMessage response;

                if (CurrentLimitMinute == null)
                {
                    response = await GetResponse(url);

                    if (response.IsSuccessStatusCode) return response;
                }

                switch (CurrentLimitMinute)
                {
                    case <= 0:
                    {
                        var difference = TimeSpan.FromSeconds(61) - TimeSpan.FromSeconds(LastDateRequest.Second);
                        await Task.Delay(difference);

                        response = await GetResponse(url);

                        if (response.IsSuccessStatusCode) return response;
                        parameters = null;
                        useApiKey = false;
                        continue;
                    }
                    case > 0:
                    {
                        response = await GetResponse(url);
                        if (response.IsSuccessStatusCode) return response;
                        parameters = null;
                        useApiKey = false;
                        continue;
                    }
                    default:
                        throw new ArgumentNullException(nameof(CurrentLimitMinute));
                }
            }
        }

        private async Task<HttpResponseMessage> GetResponse(string url)
        {
            var response = await _client.GetAsync(url);
            GetCurrentLimit(response.Headers);
            return response;
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException(nameof(url));
            }

            if (ApiKey != null)
            {
                url += $"&api_key={ApiKey}";
            }

            HttpResponseMessage response;

            if (CurrentLimitMinute == null)
            {
                response = await _client.PostAsync(url, null);
                GetCurrentLimit(response.Headers);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
            }

            switch (CurrentLimitMinute)
            {
                case <= 0:
                {
                    var difference = TimeSpan.FromSeconds(61) - TimeSpan.FromSeconds(LastDateRequest.Second);

                    await Task.Delay(difference);

                    response = await _client.PostAsync(url, null);
                    GetCurrentLimit(response.Headers);
                    response.EnsureSuccessStatusCode();

                    return response;
                }
                default:
                    response = await _client.PostAsync(url, null);
                    GetCurrentLimit(response.Headers);
                    response.EnsureSuccessStatusCode();
                    return response;
            }
        }


        private void GetCurrentLimit(HttpHeaders headers)
        {
            CurrentLimitMonth = int.Parse(headers.GetValues("x-rate-limit-remaining-month").First());
            CurrentLimitMinute = int.Parse(headers.GetValues("x-rate-limit-remaining-minute").First());
            LastDateRequest = DateTime.Parse(headers.GetValues("Date").First());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _handler?.Dispose();
                _client?.Dispose();
            }

            _disposed = true;
        }

        ~RequestHandler()
        {
            Dispose(false);
        }
    }
}