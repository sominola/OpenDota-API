using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model
{
    public class MmrEstimate
    {
        [JsonPropertyName("estimate")]
        public int? Estimate { get; set; }
    }
}