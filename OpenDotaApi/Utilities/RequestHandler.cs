using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace OpenDotaApi.Utilities
{
    using JsonConverters;
    public class RequestHandler : IDisposable
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _clientHandler;
        private bool _disposed;

        private readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        private readonly Timer _timer = new Timer {Interval = 61000};

        private int _countRequests;
        private readonly int _maxRequests;
        public string ApiKey { get; set; }

        public RequestHandler(string apiKey = null, IWebProxy proxy = null)
        {
            _maxRequests = apiKey != null ? 1000 : 60;

            _timer.Elapsed += (_, _) =>
            {
                _countRequests = 0;
                _resetEvent.Set();
            };

            this._clientHandler = new HttpClientHandler {UseProxy = proxy != null, Proxy = proxy};
            this._client = new HttpClient(_clientHandler)
            {
                BaseAddress = new Uri("https://api.opendota.com/api/"),
            };
        }

        public async Task<T> GetResponseAsync<T>(string url) where T : class
        {
            _timer.Enabled = true;
            if (_countRequests == _maxRequests)
            {
                _resetEvent.WaitOne();
                _resetEvent.Reset();
            }

            _countRequests++;
   
            var response = await _client.GetAsync(url + "");
            var textResponse = await response.Content.ReadAsStringAsync();
            
            return string.IsNullOrEmpty(textResponse) ? null : JsonDeserialize<T>.Deserialize(textResponse);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string url, HttpContent content = null)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));
            content = new StringContent("");
            return await _client.PostAsync(url, content);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _clientHandler.Dispose();
                _client.Dispose();
            }

            _disposed = true;
        }
    }
  
}