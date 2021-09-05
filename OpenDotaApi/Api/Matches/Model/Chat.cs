using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class Chat
    {
        [JsonPropertyName("time")]
        public int? Time { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("slot")]
        public long? Slot { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}