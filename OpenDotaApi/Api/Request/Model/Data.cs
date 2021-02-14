using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Request.Model
{
    public class Data
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("pgroup")]
        public Dictionary<string, Pgroup> Pgroup { get; set; }

        [JsonPropertyName("ability_upgrades")]
        public List<object> AbilityUpgrades { get; set; }
    }
}