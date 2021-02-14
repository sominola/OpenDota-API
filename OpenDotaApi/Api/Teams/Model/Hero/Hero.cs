using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Teams.Model.Hero
{
    public class Hero
    {
        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("localized_name")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("games_played")]
        public int? GamesPlayed { get; set; }

        [JsonPropertyName("wins")]
        public int? Wins { get; set; }
    }
}