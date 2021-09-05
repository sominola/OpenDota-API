using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Matches
{
    public class Heroes
    {
        [JsonPropertyName("player_slot")]
        public PlayerSlot PlayerSlot { get; set; }
    }
}