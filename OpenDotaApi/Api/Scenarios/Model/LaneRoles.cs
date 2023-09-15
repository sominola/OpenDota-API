using System.Text.Json.Serialization;
using OpenDotaApi.Utilities.JsonConverters;

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

        [JsonConverter(typeof(Int64Converter))]
        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonConverter(typeof(Int64Converter))]
        [JsonPropertyName("wins")]
        public long? Wins { get; set; }
    }
}