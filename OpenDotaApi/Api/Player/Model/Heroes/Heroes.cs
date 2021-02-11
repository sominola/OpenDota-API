using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.Heroes
{
    public class Heroes
    {
        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("last_played")]
        public int? LastPlayed { get; set; }

        [JsonPropertyName("games")]
        public int? Games { get; set; }

        [JsonPropertyName("win")]
        public int? Win { get; set; }

        [JsonPropertyName("with_games")]
        public int? WithGames { get; set; }

        [JsonPropertyName("with_win")]
        public int? WithWin { get; set; }

        [JsonPropertyName("against_games")]
        public int? AgainstGames { get; set; }

        [JsonPropertyName("against_win")]
        public int? AgainstWin { get; set; }
    }
}