using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Scenarios.Model
{
    public class LaneRoles
    {
        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("lane_role")]
        public int? LaneRole { get; set; }

        [JsonPropertyName("time")]
        public int? Time { get; set; }

        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonPropertyName("wins")]
        public long? Wins { get; set; }
    }
}