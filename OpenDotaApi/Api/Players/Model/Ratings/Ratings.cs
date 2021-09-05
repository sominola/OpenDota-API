using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Ratings
{
    public class Ratings
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("solo_competitive_rank")]
        public int? SoloCompetitiveRank { get; set; }

        [JsonPropertyName("competitive_rank")]
        public int? CompetitiveRank { get; set; }

        [JsonPropertyName("time")]
        public DateTimeOffset Time { get; set; }
    }
}