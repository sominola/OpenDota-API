using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
{
    public class KillLog
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("time")]
        public long? Time { get; set; }
    }
}