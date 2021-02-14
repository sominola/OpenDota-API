using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Scenarios.Model
{
    public class TeamScenarios
    {
        [JsonPropertyName("scenario")]
        public string Scenario { get; set; }

        [JsonPropertyName("is_radiant")]
        public bool? IsRadiant { get; set; }

        [JsonPropertyName("region")]
        public long? Region { get; set; }

        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonPropertyName("wins")]
        public long? Wins { get; set; }
    }
}