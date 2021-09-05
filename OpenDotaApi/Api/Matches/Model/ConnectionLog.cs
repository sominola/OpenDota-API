using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class ConnectionLog
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }

        [JsonPropertyName("slot")]
        public long? Slot { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}