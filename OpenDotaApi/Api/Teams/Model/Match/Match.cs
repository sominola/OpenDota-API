using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Teams.Model.Match
{
    public class Match
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("radiant")]
        public bool? Radiant { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("leagueid")]
        public long? Leagueid { get; set; }

        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("cluster")]
        public int? Cluster { get; set; }

        [JsonPropertyName("opposing_team_id")]
        public int? OpposingTeamId { get; set; }

        [JsonPropertyName("opposing_team_name")]
        public string OpposingTeamName { get; set; }

        [JsonPropertyName("opposing_team_logo")]
        public Uri OpposingTeamLogo { get; set; }
    }
}