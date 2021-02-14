using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Benchmarks.Model
{
    public class Benchmarks
    {
        [JsonPropertyName("hero_id")]
        public long? HeroId { get; set; }

        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }
}