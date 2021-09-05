using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Pro
{
    public class Pro
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("fantasy_role")]
        public int? FantasyRole { get; set; }

        [JsonPropertyName("team_id")]
        public int? TeamId { get; set; }

        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        [JsonPropertyName("team_tag")]
        public string TeamTag { get; set; }

        [JsonPropertyName("is_locked")]
        public bool? IsLocked { get; set; }

        [JsonPropertyName("is_pro")]
        public bool? IsPro { get; set; }

        [JsonPropertyName("locked_until")]
        public long? LockedUntil { get; set; }

        [JsonPropertyName("steamid")]
        public long? Steamid { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarmedium")]
        public Uri AvatarMedium { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri AvatarFull { get; set; }

        [JsonPropertyName("profileurl")]
        public Uri ProfileUrl { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        [JsonPropertyName("cheese")]
        public int? Cheese { get; set; }

        [JsonPropertyName("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonPropertyName("last_played")]
        public int? LastPlayed { get; set; }

        [JsonPropertyName("win")]
        public long? Win { get; set; }

        [JsonPropertyName("games")]
        public int? Games { get; set; }

        [JsonPropertyName("with_win")]
        public int? WithWin { get; set; }

        [JsonPropertyName("with_games")]
        public int? WithGames { get; set; }

        [JsonPropertyName("against_win")]
        public int? AgainstWin { get; set; }

        [JsonPropertyName("against_games")]
        public int? AgainstGames { get; set; }

        [JsonPropertyName("with_gpm_sum")]
        public int? WithGpmSum { get; set; }

        [JsonPropertyName("with_xpm_sum")]
        public int? WithXpmSum { get; set; }
    }
}