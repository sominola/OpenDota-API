using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace OpenDotaApi.Api.Match.Model
{
    public class TeamfightPlayer
    {
        [JsonPropertyName("deaths_pos")]
        public Dictionary<string, Dictionary<string, int>> DeathsPos { get; set; }

        [JsonPropertyName("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        [JsonPropertyName("item_uses")]
        public Dictionary<string, long> ItemUses { get; set; }

        [JsonPropertyName("killed")]
        public Dictionary<string, long> Killed { get; set; }

        [JsonPropertyName("deaths")]
        public long? Deaths { get; set; }

        [JsonPropertyName("buybacks")]
        public long? Buybacks { get; set; }

        [JsonPropertyName("damage")]
        public long? Damage { get; set; }

        [JsonPropertyName("healing")]
        public long? Healing { get; set; }

        [JsonPropertyName("gold_delta")]
        public long? GoldDelta { get; set; }

        [JsonPropertyName("xp_delta")]
        public long? XpDelta { get; set; }

        [JsonPropertyName("xp_start")]
        public long? XpStart { get; set; }

        [JsonPropertyName("xp_end")]
        public long? XpEnd { get; set; }
    }
}