using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class MatchTeam
    {
        [JsonPropertyName("team_id")]
        public int? TeamId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("logo_url")]
        public Uri LogoUrl { get; set; }
    }
}