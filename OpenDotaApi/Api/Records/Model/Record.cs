using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Records.Model
{
    public class Record
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("score")]
        public long? Score { get; set; }
    }
}