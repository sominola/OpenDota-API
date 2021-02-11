using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace OpenDotaApi.Api.Match.Model
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