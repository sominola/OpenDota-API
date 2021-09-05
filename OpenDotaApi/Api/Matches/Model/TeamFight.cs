using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class Teamfight
    {
        [JsonPropertyName("start")]
        public int? Start { get; set; }

        [JsonPropertyName("end")]
        public int? End { get; set; }

        [JsonPropertyName("last_death")]
        public long? LastDeath { get; set; }

        [JsonPropertyName("deaths")]
        public long? Deaths { get; set; }

        [JsonPropertyName("players")]
        public List<TeamfightPlayer> Players { get; set; }
    }
}