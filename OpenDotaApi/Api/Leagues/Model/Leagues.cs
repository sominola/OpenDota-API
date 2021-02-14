using System.Text.Json.Serialization;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Leagues.Model
{
    public class Leagues
    {
        [JsonPropertyName("leagueid")]
        public int? Leagueid { get; set; }

        [JsonPropertyName("ticket")]
        public string Ticket { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("tier")]
        public LeagueTier? Tier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}