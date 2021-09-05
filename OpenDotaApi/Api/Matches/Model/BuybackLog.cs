using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class BuybackLog
    {
        [JsonPropertyName("time")]
        public int? Time { get; set; }

        [JsonPropertyName("slot")]
        public long? Slot { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }
    }
}