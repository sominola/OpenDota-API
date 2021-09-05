using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class PurchaseLog
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }
    }
}