using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class RuneLog
    {
        [JsonPropertyName("key")]
        public long? Key { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }
    }
}