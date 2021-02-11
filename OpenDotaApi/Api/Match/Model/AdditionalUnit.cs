using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class AdditionalUnit
    {
        [JsonPropertyName("unitname")]
        public string UnitName { get; set; }

        [JsonPropertyName("item_0")]
        public int? Item0 { get; set; }

        [JsonPropertyName("item_1")]
        public int? Item1 { get; set; }

        [JsonPropertyName("item_2")]
        public int? Item2 { get; set; }

        [JsonPropertyName("item_3")]
        public int? Item3 { get; set; }

        [JsonPropertyName("item_4")]
        public int? Item4 { get; set; }

        [JsonPropertyName("item_5")]
        public int? Item5 { get; set; }

        [JsonPropertyName("backpack_0")]
        public int? Backpack0 { get; set; }

        [JsonPropertyName("backpack_1")]
        public int? Backpack1 { get; set; }

        [JsonPropertyName("backpack_2")]
        public int? Backpack2 { get; set; }
    }
}