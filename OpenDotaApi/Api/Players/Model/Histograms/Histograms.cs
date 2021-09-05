using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Histograms
{
    public class Histograms
    {
        [JsonPropertyName("x")]
        public long? X { get; set; }

        [JsonPropertyName("games")]
        public int Games { get; set; }

        [JsonPropertyName("win")]
        public int Win { get; set; }
    }
}