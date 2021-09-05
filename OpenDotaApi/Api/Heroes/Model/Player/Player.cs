using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Heroes.Model.Player
{
    public class Player
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("games_played")]
        public int? GamesPlayed { get; set; }

        [JsonPropertyName("wins")]
        public int? Wins { get; set; }
    }
}