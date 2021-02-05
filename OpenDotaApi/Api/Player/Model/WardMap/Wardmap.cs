using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.WardMap
{
    public class WardMap
    {
        [JsonPropertyName("obs")]
        public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

        [JsonPropertyName("sen")]
        public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
    }
}