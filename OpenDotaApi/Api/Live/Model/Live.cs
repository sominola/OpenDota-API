using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenDotaApi.Utilities.JsonConverters;

namespace OpenDotaApi.Api.Live.Model
{
    public class Live
    {
        [JsonPropertyName("activate_time")]
        public DateTime? ActivateTime { get; set; }

        [JsonPropertyName("deactivate_time")]
        public long? DeactivateTime { get; set; }

        [JsonPropertyName("server_steam_id")]
        public string ServerSteamId { get; set; }

        [JsonPropertyName("lobby_id")]
        public string LobbyId { get; set; }

        [JsonPropertyName("league_id")]
        public long? LeagueId { get; set; }

        [JsonPropertyName("lobby_type")]
        public int? LobbyType { get; set; }

        [JsonPropertyName("game_time")]
        public long? GameTime { get; set; }

        [JsonPropertyName("delay")]
        public int? Delay { get; set; }

        [JsonPropertyName("spectators")]
        public int? Spectators { get; set; }

        [JsonPropertyName("game_mode")]
        public int? GameMode { get; set; }

        [JsonPropertyName("average_mmr")]
        public int? AverageMmr { get; set; }

        [JsonConverter(typeof(Int64Converter))]
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("series_id")]
        public int? SeriesId { get; set; }

        [JsonPropertyName("sort_score")]
        public long? SortScore { get; set; }

        [JsonPropertyName("last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

        [JsonPropertyName("radiant_lead")]
        public int? RadiantLead { get; set; }

        [JsonPropertyName("radiant_score")]
        public int? RadiantScore { get; set; }

        [JsonPropertyName("dire_score")]
        public int? DireScore { get; set; }

        [JsonPropertyName("players")]
        public List<Player> Players { get; set; }

        [JsonPropertyName("building_state")]
        public long? BuildingState { get; set; }

        [JsonPropertyName("custom_game_difficulty")]
        public long? CustomGameDifficulty { get; set; }

        [JsonPropertyName("team_name_radiant")]
        public string TeamNameRadiant { get; set; }

        [JsonPropertyName("team_name_dire")]
        public string TeamNameDire { get; set; }

        [JsonPropertyName("team_logo_radiant")]
        public string TeamLogoRadiant { get; set; }

        [JsonPropertyName("team_logo_dire")]
        public string TeamLogoDire { get; set; }

        [JsonPropertyName("team_id_radiant")]
        public long? TeamIdRadiant { get; set; }

        [JsonPropertyName("team_id_dire")]
        public long? TeamIdDire { get; set; }
    }
}