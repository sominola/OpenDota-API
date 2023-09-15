using System.Text.Json.Serialization;
using OpenDotaApi.Utilities.JsonConverters;

namespace OpenDotaApi.Api.Status.Model
{
    public class ApiPath
    {
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        [JsonConverter(typeof(Int32Converter))]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }
}