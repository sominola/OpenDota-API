using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class Objective
    {
        [JsonPropertyName("time")]
        public long? Time { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("slot")]
        public long? Slot { get; set; }

        [JsonPropertyName("key")]
        public dynamic Key { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("team")]
        public long? Team { get; set; }
    }
}