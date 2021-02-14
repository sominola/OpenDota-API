using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Benchmarks.Model
{
    public class Result
    {
        public List<BenchmarkValue> GoldPerMin { get; set; }

        [JsonPropertyName("xp_per_min")]
        public List<BenchmarkValue> XpPerMin { get; set; }

        [JsonPropertyName("kills_per_min")]
        public List<BenchmarkValue> KillsPerMin { get; set; }

        [JsonPropertyName("last_hits_per_min")]
        public List<BenchmarkValue> LastHitsPerMin { get; set; }

        [JsonPropertyName("hero_damage_per_min")]
        public List<BenchmarkValue> HeroDamagePerMin { get; set; }

        [JsonPropertyName("hero_healing_per_min")]
        public List<BenchmarkValue> HeroHealingPerMin { get; set; }

        [JsonPropertyName("tower_damage")]
        public List<BenchmarkValue> TowerDamage { get; set; }

        [JsonPropertyName("stuns_per_min")]
        public List<BenchmarkValue> StunsPerMin { get; set; }

        [JsonPropertyName("lhten")]
        public List<BenchmarkValue> Lhten { get; set; }
    }
}