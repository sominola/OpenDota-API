using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Status.Model
{
    public class Status
    {
         [JsonPropertyName("user_players")]
        public int? UserPlayers { get; set; }

        [JsonPropertyName("tracked_players")]
        public int? TrackedPlayers { get; set; }

        [JsonPropertyName("matches_last_day")]
        public int? MatchesLastDay { get; set; }

        [JsonPropertyName("matches_last_hour")]
        public int? MatchesLastHour { get; set; }

        [JsonPropertyName("retriever_matches_last_day")]
        public int? RetrieverMatchesLastDay { get; set; }

        [JsonPropertyName("retriever_players_last_day")]
        public long? RetrieverPlayersLastDay { get; set; }

        [JsonPropertyName("backup_retriever_last_day")]
        public long? BackupRetrieverLastDay { get; set; }

        [JsonPropertyName("parsed_matches_last_day")]
        public int? ParsedMatchesLastDay { get; set; }

        [JsonPropertyName("requests_last_day")]
        public long? RequestsLastDay { get; set; }

        [JsonPropertyName("fullhistory_last_day")]
        public long? FullhistoryLastDay { get; set; }

        [JsonPropertyName("webhooks_last_day")]
        public int? WebhooksLastDay { get; set; }

        [JsonPropertyName("feed_last_day")]
        public long? FeedLastDay { get; set; }

        [JsonPropertyName("api_hits_last_day")]
        public long? ApiHitsLastDay { get; set; }

        [JsonPropertyName("api_hits_ui_last_day")]
        public long? ApiHitsUiLastDay { get; set; }

        [JsonPropertyName("fhQueue")]
        public long? FhQueue { get; set; }

        [JsonPropertyName("gcQueue")]
        public int? GcQueue { get; set; }

        [JsonPropertyName("mmrQueue")]
        public int? MmrQueue { get; set; }

        [JsonPropertyName("countsQueue")]
        public int? CountsQueue { get; set; }

        [JsonPropertyName("scenariosQueue")]
        public long? ScenariosQueue { get; set; }

        [JsonPropertyName("benchmarksQueue")]
        public long? BenchmarksQueue { get; set; }

        [JsonPropertyName("retriever")]
        public List<ApiPath> Retriever { get; set; }

        [JsonPropertyName("api_paths")]
        public List<ApiPath> ApiPaths { get; set; }

        [JsonPropertyName("last_added")]
        public List<Last> LastAdded { get; set; }

        [JsonPropertyName("last_parsed")]
        public List<Last> LastParsed { get; set; }

        [JsonPropertyName("load_times")]
        public Dictionary<string, long> LoadTimes { get; set; }

        [JsonPropertyName("health")]
        public Health Health { get; set; }
    }
}