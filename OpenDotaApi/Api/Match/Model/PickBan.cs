using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class PickBan
    {
        [JsonPropertyName("is_pick")]
        public bool? IsPick { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("team")]
        public int? Team { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }

        [JsonPropertyName("ord")]
        public long? Ord { get; set; }

        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }
    }
}