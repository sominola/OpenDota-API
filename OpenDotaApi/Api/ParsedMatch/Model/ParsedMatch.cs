using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.ParsedMatch.Model
{
    public class ParsedMatch
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }
    }
}