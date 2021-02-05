using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.Totals
{
    public class Totals
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("n")]
        public long? N { get; set; }

        [JsonPropertyName("sum")]
        public double? Sum { get; set; }
    }
}