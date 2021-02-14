using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Status.Model
{
    public class Last
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }
    }
}