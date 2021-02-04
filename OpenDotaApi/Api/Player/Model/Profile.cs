using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace OpenDotaApi.Api.Player.Model
{
    public class Profile
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        [JsonProperty("cheese")]
        public long Cheese { get; set; }

        [JsonProperty("steamid")]
        public string Steamid { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonProperty("profileurl")]
        public Uri Profileurl { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonProperty("is_contributor")]
        public bool IsContributor { get; set; }
    }
}