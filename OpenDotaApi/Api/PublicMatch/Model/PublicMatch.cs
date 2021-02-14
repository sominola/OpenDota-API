using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.PublicMatch.Model
{
    public class PublicMatch
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("match_seq_num")]
        public long? MatchSeqNum { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("avg_mmr")]
        public int? AvgMmr { get; set; }

        [JsonPropertyName("num_mmr")]
        public int? NumMmr { get; set; }

        [JsonPropertyName("lobby_type")]
        public int? LobbyType { get; set; }

        [JsonPropertyName("game_mode")]
        public int? GameMode { get; set; }

        [JsonPropertyName("avg_rank_tier")]
        public int? AvgRankTier { get; set; }

        [JsonPropertyName("num_rank_tier")]
        public int? NumRankTier { get; set; }

        [JsonPropertyName("cluster")]
        public int? Cluster { get; set; }

        [JsonPropertyName("radiant_team")]
        public string RadiantTeam { get; set; }

        [JsonPropertyName("dire_team")]
        public string DireTeam { get; set; }
    }
}