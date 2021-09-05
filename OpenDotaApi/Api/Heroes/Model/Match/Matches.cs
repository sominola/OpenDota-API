using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Heroes.Model.Match
{
    public class Match
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("duration")]
        public long? Duration { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("leagueid")]
        public int? Leagueid { get; set; }

        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("radiant")]
        public bool? Radiant { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }

        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("kills")]
        public int? Kills { get; set; }

        [JsonPropertyName("deaths")]
        public int? Deaths { get; set; }

        [JsonPropertyName("assists")]
        public int? Assists { get; set; }
    }
}