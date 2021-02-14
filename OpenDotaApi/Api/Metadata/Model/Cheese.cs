using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Metadata.Model
{
    public class Cheese
    {
        [JsonPropertyName("cheese")]
        public int CheeseAmount { get; set; }

        [JsonPropertyName("goal")]
        public int Goal { get; set; }
    }
}