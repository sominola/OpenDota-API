using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Rankings.Model
{
    public class Rankings
    {
        [JsonPropertyName("hero_id")]
        public long? HeroId { get; set; }

        [JsonPropertyName("rankings")]
        public List<Ranking> ListRankings { get; set; }
    }
}