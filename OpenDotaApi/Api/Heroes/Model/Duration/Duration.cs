using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Heroes.Model.Duration
{
    public class Duration
    {
        [JsonPropertyName("duration_bin")]
        public int? DurationBin { get; set; }

        [JsonPropertyName("games_played")]
        public int? GamesPlayed { get; set; }

        [JsonPropertyName("wins")]
        public int? Wins { get; set; }
    }
}