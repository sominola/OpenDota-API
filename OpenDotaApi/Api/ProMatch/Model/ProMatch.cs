using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.ProMatch.Model
{
    public class ProMatch
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        [JsonPropertyName("radiant_team_id")]
        public long? RadiantTeamId { get; set; }

        [JsonPropertyName("radiant_name")]
        public string RadiantName { get; set; }

        [JsonPropertyName("dire_team_id")]
        public long? DireTeamId { get; set; }

        [JsonPropertyName("dire_name")]
        public string DireName { get; set; }

        [JsonPropertyName("leagueid")]
        public long? Leagueid { get; set; }

        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("series_id")]
        public long? SeriesId { get; set; }

        [JsonPropertyName("series_type")]
        public int? SeriesType { get; set; }

        [JsonPropertyName("radiant_score")]
        public int? RadiantScore { get; set; }

        [JsonPropertyName("dire_score")]
        public int? DireScore { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }
    }
}