using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.Matches
{
    public class Matches
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("player_slot")]
        public int? PlayerSlot { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("duration")]
        public long? Duration { get; set; }

        [JsonPropertyName("game_mode")]
        public int? GameMode { get; set; }

        [JsonPropertyName("lobby_type")]
        public int? LobbyType { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

        [JsonPropertyName("kills")]
        public int? Kills { get; set; }

        [JsonPropertyName("deaths")]
        public int? Deaths { get; set; }

        [JsonPropertyName("assists")]
        public int? Assists { get; set; }

        [JsonPropertyName("skill")]
        public int? Skill { get; set; }

        [JsonPropertyName("party_size")]
        public int? PartySize { get; set; }

        [JsonPropertyName("heroes")]
        public Heroes Heroes { get; set; }
    }

   
}