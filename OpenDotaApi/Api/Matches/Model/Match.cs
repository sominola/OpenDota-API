using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class Match
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("barracks_status_dire")]
        public int? BarracksStatusDire { get; set; }

        [JsonPropertyName("barracks_status_radiant")]
        public int? BarracksStatusRadiant { get; set; }

        [JsonPropertyName("chat")]
        public List<Chat> Chat { get; set; }

        [JsonPropertyName("cluster")]
        public int? Cluster { get; set; }

        [JsonPropertyName("cosmetics")]
        public Dictionary<string, long> Cosmetics { get; set; }

        [JsonPropertyName("dire_score")]
        public int? DireScore { get; set; }

        [JsonPropertyName("dire_team_id")]
        public int? DireTeamId { get; set; }

        [JsonPropertyName("draft_timings")]
        public List<DraftTiming> DraftTimings { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("engine")]
        public int? Engine { get; set; }

        [JsonPropertyName("first_blood_time")]
        public long? FirstBloodTime { get; set; }

        [JsonPropertyName("game_mode")]
        public int? GameMode { get; set; }

        [JsonPropertyName("human_players")]
        public int? HumanPlayers { get; set; }

        [JsonPropertyName("leagueid")]
        public int? Leagueid { get; set; }

        [JsonPropertyName("lobby_type")]
        public long? LobbyType { get; set; }

        [JsonPropertyName("match_seq_num")]
        public long? MatchSeqNum { get; set; }

        [JsonPropertyName("negative_votes")]
        public long? NegativeVotes { get; set; }

        [JsonPropertyName("objectives")]
        public List<Objective> Objectives { get; set; }

        [JsonPropertyName("picks_bans")]
        public List<PickBan> PicksBans { get; set; }

        [JsonPropertyName("positive_votes")]
        public int? PositiveVotes { get; set; }

        [JsonPropertyName("radiant_gold_adv")]
        public List<int> RadiantGoldAdvantage { get; set; }

        [JsonPropertyName("radiant_score")]
        public int? RadiantScore { get; set; }

        [JsonPropertyName("radiant_team_id")]
        public int? RadiantTeamId { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("radiant_xp_adv")]
        public List<int> RadiantXpAdvantage { get; set; }

        [JsonPropertyName("skill")]
        public int? Skill { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("teamfights")]
        public List<Teamfight> Teamfights { get; set; }

        [JsonPropertyName("tower_status_dire")]
        public int? TowerStatusDire { get; set; }

        [JsonPropertyName("tower_status_radiant")]
        public int? TowerStatusRadiant { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

        [JsonPropertyName("replay_salt")]
        public long? ReplaySalt { get; set; }

        [JsonPropertyName("series_id")]
        public long? SeriesId { get; set; }

        [JsonPropertyName("series_type")]
        public long? SeriesType { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("radiant_team")]
        public MatchTeam RadiantTeam { get; set; }

        [JsonPropertyName("dire_team")]
        public MatchTeam DireTeam { get; set; }

        [JsonPropertyName("players")]
        public List<MatchPlayer> Players { get; set; }

        [JsonPropertyName("patch")]
        public int? Patch { get; set; }

        [JsonPropertyName("region")]
        public int? Region { get; set; }

        [JsonPropertyName("all_word_counts")]
        public Dictionary<string, int> AllWordCounts { get; set; }

        [JsonPropertyName("my_word_counts")]
        public Dictionary<string, int> MyWordCounts { get; set; }

        [JsonPropertyName("throw")]
        public int? Throw { get; set; }

        [JsonPropertyName("comeback")]
        public int? Comeback { get; set; }

        [JsonPropertyName("stomp")]
        public int? Stomp { get; set; }

        [JsonPropertyName("loss")]
        public int? Loss { get; set; }

        [JsonPropertyName("win")]
        public int? Win { get; set; }

        [JsonPropertyName("replay_url")]
        public Uri ReplayUrl { get; set; }
    }
}