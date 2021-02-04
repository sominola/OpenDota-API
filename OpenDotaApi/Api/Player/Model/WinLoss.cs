using Newtonsoft.Json;

namespace OpenDotaApi.Api.Player.Model
{
    public class WinLoss
    {
        [JsonProperty("win")]
        public long Win { get; set; }

        [JsonProperty("lose")]
        public long Lose { get; set; }
    }
}