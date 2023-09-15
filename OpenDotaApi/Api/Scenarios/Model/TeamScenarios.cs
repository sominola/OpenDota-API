using System.Text.Json.Serialization;
using OpenDotaApi.Utilities.JsonConverters;

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

        [JsonConverter(typeof(Int64Converter))]
        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonConverter(typeof(Int64Converter))]
        [JsonPropertyName("wins")]
        public long? Wins { get; set; }
    }
}