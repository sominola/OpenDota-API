using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using OpenDotaApi.Utilities.JsonConverters;

namespace OpenDotaApi.Utilities
{
    public sealed class JsonFormatter : IDisposable
    {
        private readonly RequestHandler _request;
        private readonly JsonSerializerOptions _options;

        public JsonFormatter(RequestHandler request)
        {
            _request = request;

            _options = new JsonSerializerOptions();
            _options.Converters.Add(new Int32Converter());
            _options.Converters.Add(new DateTimeConverter());
            _options.Converters.Add(new Int64Converter());
        }

        public async Task<T> DeserializeAsync<T>(string url, string parameters = null) where T : class
        {
            var response = await _request.GetResponseAsync(url, parameters);

            if (!response.IsSuccessStatusCode)
                return null;

            var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(stream, _options);
        }

        public async Task<T> DeserializeAsync<T>(Stream json)
        {
            if (json == null)
                throw new NullReferenceException();

            return await JsonSerializer.DeserializeAsync<T>(json, _options);
        }


        public void Dispose()
        {
            _request?.Dispose();
        }
    }
}