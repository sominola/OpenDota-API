using System;
using System.Net;
using OpenDotaApi.Utilities;

namespace OpenDotaApi
{
    using Api.Heroes;
    using Api.Matches;
    using Api.ParsedMatches;
    using Api.Players;
    using Api.ProMatches;
    using Api.ProPlayers;
    using Api.PublicMatches;
    using Api.Replays;
    using Api.PlayersByRank;
    using Api.Metadata;
    using Api.Distributions;
    using Api.Search;
    using Api.Rankings;
    using Api.Benchmarks;
    using Api.Status;
    using Api.Health;
    using Api.Request;
    using Api.FindMatches;
    using Api.HeroStats;
    using Api.Leagues;
    using Api.Teams;
    using Api.Records;
    using Api.Live;
    using Api.Scenarios;
    using Api.Schema;
    using Api.Constants;

    public class OpenDota : IDisposable
    {
        public OpenDota(string apiKey = null, IWebProxy proxy = null)
        {
            _request = new RequestHandler(apiKey, proxy);
            _jsonFormatter = new JsonFormatter(_request);

            Matches = new MatchesEndpoint(_jsonFormatter);
            PlayersByRank = new PlayersByRankEndpoint(_jsonFormatter);
            Players = new PlayersEndpoint(_jsonFormatter, _request);
            ProPlayers = new ProPlayersEndpoint(_jsonFormatter);
            ProMatches = new ProMatchesEndpoint(_jsonFormatter);
            PublicMatches = new PublicMatchesEndpoint(_jsonFormatter);
            ParsedMatches = new ParsedMatchesEndpoint(_jsonFormatter);
            Metadata = new MetadataEndpoint(_jsonFormatter);
            Distributions = new DistributionsEndpoint(_jsonFormatter);
            Search = new SearchEndpoint(_jsonFormatter);
            Rankings = new RankingsEndpoint(_jsonFormatter);
            Benchmarks = new BenchmarksEndpoint(_jsonFormatter);
            Status = new StatusEndpoint(_jsonFormatter);
            Health = new HealthEndpoint(_jsonFormatter);
            Request = new RequestEndpoint(_jsonFormatter, _request);
            FindMatches = new FindMatchesEndpoint(_jsonFormatter);
            Heroes = new HeroesEndpoint(_jsonFormatter);
            HeroStats = new HeroStatsEndpoint(_jsonFormatter);
            Leagues = new LeaguesEndpoint(_jsonFormatter);
            Teams = new TeamsEndpoint(_jsonFormatter);
            Replayses = new ReplaysEndpoint(_jsonFormatter);
            Recordses = new RecordsEndpoint(_jsonFormatter);
            Live = new LiveEndpoint(_jsonFormatter);
            Scenarios = new ScenariosEndpoint(_jsonFormatter);
            Schema = new SchemaEndpoint(_jsonFormatter);
            Constants = new ConstantsEndpoint(_jsonFormatter, _request);
        }

        private readonly RequestHandler _request;
        private readonly JsonFormatter _jsonFormatter;

        public readonly IMatchesEndpoint Matches;
        public readonly IPlayersByRankEndpoint PlayersByRank;
        public readonly IPlayersEndpoint Players;
        public readonly IProPlayersEndpoint ProPlayers;
        public readonly IProMatchesEndpoint ProMatches;
        public readonly IPublicMatchesEndpoint PublicMatches;
        public readonly IParsedMatchesEndpoint ParsedMatches;
        public readonly IMetadataEndpoint Metadata;
        public readonly IDistributionsEndpoint Distributions;
        public readonly ISearchEndpoint Search;
        public readonly IRankingsEndpoint Rankings;
        public readonly IBenchmarksEndpoint Benchmarks;
        public readonly IStatusEndpoint Status;
        public readonly IHealthEndpoint Health;
        public readonly IRequestEndpoint Request;
        public readonly IFindMatchesEndpoint FindMatches;
        public readonly IHeroesEndpoint Heroes;
        public readonly IHeroStatsEndpoint HeroStats;
        public readonly ILeaguesEndpoint Leagues;
        public readonly ITeamsEndpoint Teams;
        public readonly IReplaysEndpoint Replayses;
        public readonly IRecordsEndpoint Recordses;
        public readonly ILiveEndpoint Live;
        public readonly IScenariosEndpoint Scenarios;
        public readonly ISchemaEndpoint Schema;
        public readonly IConstantsEndpoint Constants;

        public int? GetCurrentLimitMinute()
        {
            return _request.CurrentLimitMinute;
        }

        public int? GetCurrentLimitMonth()
        {
            return _request.CurrentLimitMonth;
        }

        public void Dispose()
        {
            _jsonFormatter.Dispose();
        }
    }
}