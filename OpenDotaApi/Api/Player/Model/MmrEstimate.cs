using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model
{
    public class MmrEstimate
    {
        [JsonPropertyName("estimate")]
        public int? Estimate { get; set; }
    }
}