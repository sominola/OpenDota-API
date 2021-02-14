using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Status.Model
{
    public class Health
    {
        [JsonPropertyName("cassandraUsage")]
        public HealthValues CassandraUsage { get; set; }

        [JsonPropertyName("gcDelay")]
        public HealthValues GcDelay { get; set; }

        [JsonPropertyName("redisUsage")]
        public HealthValues RedisUsage { get; set; }

        [JsonPropertyName("postgresUsage")]
        public HealthValues PostgresUsage { get; set; }

        [JsonPropertyName("seqNumDelay")]
        public HealthValues SeqNumDelay { get; set; }

        [JsonPropertyName("parseDelay")]
        public HealthValues ParseDelay { get; set; }

        [JsonPropertyName("steamApi")]
        public HealthValues SteamApi { get; set; }
    }
}