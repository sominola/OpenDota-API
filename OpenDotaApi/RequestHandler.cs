using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace OpenDotaApi
{
    public class RequestHandler : IDisposable
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _clientHandler;
        private bool _disposed;
        private readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        private readonly Timer _timer = new Timer{Interval = 63000};
        private int _countRequests;
        public RequestHandler(IWebProxy proxy = null)
        {
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
        public async Task<string> GetResponseAsync(string url)
        {
            _timer.Enabled = true;
            if (_countRequests == 60)
            {
                Console.WriteLine("Many Request wait");
                _resetEvent.WaitOne();
                _resetEvent.Reset();
            }

            _countRequests++;
            return await _client.GetStringAsync(url);
        }

        public async Task<T> GetResponseAsync<T>(string url) where T: class
        {
            return await _client.GetFromJsonAsync<T>(url);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string url,HttpContent content = null)
        {
            content = new StringContent("");
            return await _client.PostAsync(url,content);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
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