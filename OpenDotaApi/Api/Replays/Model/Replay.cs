using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Replays.Model
{
    public class Replay
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("cluster")]
        public int? Cluster { get; set; }

        [JsonPropertyName("replay_salt")]
        public long? ReplaySalt { get; set; }
    }
}