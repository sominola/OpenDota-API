using Newtonsoft.Json;

namespace OpenDotaApi.Api.Player.Model
{
    public class MmrEstimate
    {
        [JsonProperty("estimate")] public int? Estimate { get; set; }
    }
}