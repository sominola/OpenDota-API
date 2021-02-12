using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.ProPlayer.Model
{
    public class ProPlayer
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("steamid")]
        public string Steamid { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonPropertyName("profileurl")]
        public Uri Profileurl { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        [JsonPropertyName("cheese")]
        public int Cheese { get; set; }

        [JsonPropertyName("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonPropertyName("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        [JsonPropertyName("plus")]
        public bool? Plus { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("fantasy_role")]
        public int FantasyRole { get; set; }

        [JsonPropertyName("team_id")]
        public long TeamId { get; set; }

        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        [JsonPropertyName("team_tag")]
        public string TeamTag { get; set; }

        [JsonPropertyName("is_locked")]
        public bool IsLocked { get; set; }

        [JsonPropertyName("is_pro")]
        public bool IsPro { get; set; }
    }
}