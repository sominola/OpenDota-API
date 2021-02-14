using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Live.Model
{
    public class Player
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("fantasy_role")]
        public int? FantasyRole { get; set; }

        [JsonPropertyName("team_id")]
        public long? TeamId { get; set; }

        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        [JsonPropertyName("team_tag")]
        public string TeamTag { get; set; }

        [JsonPropertyName("is_locked")]
        public bool? IsLocked { get; set; }

        [JsonPropertyName("is_pro")]
        public bool? IsPro { get; set; }

        // [JsonPropertyName("locked_until")]
        // public object LockedUntil { get; set; }
    }
}