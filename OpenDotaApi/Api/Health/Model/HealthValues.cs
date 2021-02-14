using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Health.Model
{
    public class HealthValues
    {
        [JsonPropertyName("metric")]
        public double? Metric { get; set; }

        [JsonPropertyName("threshold")]
        public long? Threshold { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}