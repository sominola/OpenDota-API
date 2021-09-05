using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Matches
{
    public class PlayerSlot
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }

        [JsonPropertyName("player_slot")]
        public int? SlotsPlayer { get; set; }
    }
}