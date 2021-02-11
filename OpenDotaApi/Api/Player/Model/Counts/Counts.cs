using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.Counts
{
    public class Counts
    {
        [JsonPropertyName("leaver_status")]
        public Dictionary<string, GameMode> LeaverStatus { get; set; }

        [JsonPropertyName("game_mode")]
        public Dictionary<string, GameMode> GameMode { get; set; }

        [JsonPropertyName("lobby_type")]
        public Dictionary<string, GameMode> LobbyType { get; set; }

        [JsonPropertyName("lane_role")]
        public Dictionary<string, GameMode> LaneRole { get; set; }

        [JsonPropertyName("region")]
        public Dictionary<string, GameMode> Region { get; set; }

        [JsonPropertyName("patch")]
        public Dictionary<string, GameMode> Patch { get; set; }

        [JsonPropertyName("is_radiant")]
        public Dictionary<string, GameMode> IsRadiant { get; set; }
    }
}