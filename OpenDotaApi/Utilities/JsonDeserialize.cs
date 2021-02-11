using System.Text.Json;
using OpenDotaApi.Utilities.JsonConverters;

namespace OpenDotaApi.Utilities
{
    public static class JsonDeserialize<T> where T: class
    {
        private static readonly JsonSerializerOptions _options;
        static JsonDeserialize()
        {
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new Int32Converter());
        }

        public static T Deserialize(string json)
        {
            return JsonSerializer.Deserialize<T>(json,_options);
        }
    }
}