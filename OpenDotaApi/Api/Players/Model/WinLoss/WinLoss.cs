using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.WinLoss
{
    public class WinLoss
    {
        [JsonPropertyName("win")]
        public long Win { get; set; }

        [JsonPropertyName("lose")]
        public long Lose { get; set; }
    }
}