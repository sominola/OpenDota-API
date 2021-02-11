using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.PlayersByRank.Model
{
    public class PlayersByRank
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("rating")]
        public int? Rating { get; set; }

        [JsonPropertyName("fh_unavailable")]
        public bool? FhUnavailable { get; set; }
    }
}