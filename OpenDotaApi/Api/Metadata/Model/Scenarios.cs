using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Metadata.Model
{
    public class Scenarios
    {
        [JsonPropertyName("itemCost")]
        public long? ItemCost { get; set; }

        [JsonPropertyName("timings")]
        public List<long> Timings { get; set; }

        [JsonPropertyName("gameDurationBucket")]
        public List<long> GameDurationBucket { get; set; }

        [JsonPropertyName("teamScenariosQueryParams")]
        public List<string> TeamScenariosQueryParams { get; set; }
    }
}