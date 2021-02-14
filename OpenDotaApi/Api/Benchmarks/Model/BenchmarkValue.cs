using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Benchmarks.Model
{
    public class BenchmarkValue
    {
        [JsonPropertyName("percentile")]
        public float? Percentile { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}