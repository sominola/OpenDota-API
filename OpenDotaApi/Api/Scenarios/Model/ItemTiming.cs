using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Scenarios.Model
{
    public class ItemTiming
    {
        [JsonPropertyName("hero_id")]
        public long? HeroId { get; set; }

        [JsonPropertyName("item")]
        public string Item { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }

        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonPropertyName("wins")]
        public long? Wins { get; set; }
    }
}