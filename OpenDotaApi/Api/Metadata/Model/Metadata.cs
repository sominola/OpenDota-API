using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Metadata.Model
{
    public class Metadata
    {
        [JsonPropertyName("scenarios")]
        public Scenarios Scenarios { get; set; }

        [JsonPropertyName("banner")]
        public object Banner { get; set; }

        [JsonPropertyName("cheese")]
        public Cheese Cheese { get; set; }
    }
}