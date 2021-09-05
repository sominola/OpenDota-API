using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.ParsedMatches.Model
{
    public class ParsedMatch
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }
    }
}