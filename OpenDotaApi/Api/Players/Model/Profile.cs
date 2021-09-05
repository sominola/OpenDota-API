using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model
{
    public class Profile
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("personaname")]
        public string PersonaName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("plus")]
        public bool? Plus { get; set; }

        [JsonPropertyName("cheese")]
        public int? Cheese { get; set; }

        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarmedium")]
        public Uri AvatarMedium { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonPropertyName("profileurl")]
        public Uri ProfileUrl { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string LocCountryCode { get; set; }

        [JsonPropertyName("is_contributor")]
        public bool IsContributor { get; set; }
    }
}