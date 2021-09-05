using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class RuneLog
    {
        [JsonPropertyName("key")]
        public long? Key { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }
    }
}