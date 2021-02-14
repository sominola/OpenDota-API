using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Teams.Model.Player
{
    public class Player
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("games_played")]
        public int? GamesPlayed { get; set; }

        [JsonPropertyName("wins")]
        public int? Wins { get; set; }

        [JsonPropertyName("is_current_team_member")]
        public bool? IsCurrentTeamMember { get; set; }
    }
}