using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Heroes.Model.ItemPopularity
{
    public class ItemPopularity
    {
        [JsonPropertyName("start_game_items")]
        public Dictionary<string, long> StartGameItems { get; set; }

        [JsonPropertyName("early_game_items")]
        public Dictionary<string, long> EarlyGameItems { get; set; }

        [JsonPropertyName("mid_game_items")]
        public Dictionary<string, long> MidGameItems { get; set; }

        [JsonPropertyName("late_game_items")]
        public Dictionary<string, long> LateGameItems { get; set; }
    }
}