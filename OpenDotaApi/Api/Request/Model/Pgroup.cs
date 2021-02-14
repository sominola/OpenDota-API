using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Request.Model
{
    public class Pgroup
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        [JsonPropertyName("player_slot")]
        public int PlayerSlot { get; set; }
    }
}