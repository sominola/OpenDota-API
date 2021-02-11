using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class MaxHeroHit
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("time")]
        public int? Time { get; set; }

        [JsonPropertyName("max")]
        public bool? Max { get; set; }

        [JsonPropertyName("inflictor")]
        public string Inflictor { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public long? Value { get; set; }

        [JsonPropertyName("slot")]
        public long? Slot { get; set; }

        [JsonPropertyName("player_slot")]
        public long? PlayerSlot { get; set; }
    }
}