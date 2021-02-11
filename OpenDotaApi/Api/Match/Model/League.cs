using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Match.Model
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