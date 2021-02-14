using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Search.Model
{
    public class SearchPlayer
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonPropertyName("last_match_time")]
        public DateTimeOffset? LastMatchTime { get; set; }

        [JsonPropertyName("similarity")]
        public double? Similarity { get; set; }
    }
}