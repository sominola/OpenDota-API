using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class MatchPlayerBenchmarks
    {
        [JsonPropertyName("gold_per_min")]
        public Dictionary<string, double> GoldPerMin { get; set; }

        [JsonPropertyName("xp_per_min")]
        public Dictionary<string, double> XpPerMin { get; set; }

        [JsonPropertyName("kills_per_min")]
        public Dictionary<string, double> KillsPerMin { get; set; }

        [JsonPropertyName("last_hits_per_min")]
        public Dictionary<string, double> LastHitsPerMin { get; set; }

        [JsonPropertyName("hero_damage_per_min")]
        public Dictionary<string, double> HeroDamagePerMin { get; set; }

        [JsonPropertyName("hero_healing_per_min")]
        public Dictionary<string, double> HeroHealingPerMin { get; set; }

        [JsonPropertyName("tower_damage")]
        public Dictionary<string, double> TowerDamage { get; set; }

        [JsonPropertyName("stuns_per_min")]
        public Dictionary<string, double> StunsPerMin { get; set; }

        [JsonPropertyName("lhten")]
        public Dictionary<string, double> Lhten { get; set; }
    }
}