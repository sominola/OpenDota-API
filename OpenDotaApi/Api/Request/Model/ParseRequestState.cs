using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Request.Model
{
    public class ParseRequestState
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }

        [JsonPropertyName("attempts")]
        public int? Attempts { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("next_attempt_time")]
        public DateTimeOffset? NextAttemptTime { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        [JsonPropertyName("jobId")]
        public long? JobId { get; set; }
    }
}