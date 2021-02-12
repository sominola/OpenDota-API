using System.Text.Json;
using OpenDotaApi.Utilities.JsonConverters;

namespace OpenDotaApi.Utilities
{
    public  class JsonDeserialize : IJsonDeserialize 
    {
        private  readonly JsonSerializerOptions _options; 
        public JsonDeserialize()
        {
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new Int32Converter());
        }
        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json,_options);
        }
    }
}