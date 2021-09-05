using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class League
    {
        [JsonPropertyName("leagueid")]
        public long? Leagueid { get; set; }

        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}