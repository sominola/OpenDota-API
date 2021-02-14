namespace OpenDotaApi
{
    using Utilities;
    using Api.Match;
    using Api.Player;
    using Api.PlayersByRank;
    using Api.ProPlayer;
    using Api.ProMatch;
    using Api.PublicMatch;
    using Api.ParsedMatch;
    using Api.Metadata;
    using Api.Distributions;
    using Api.Search;
    using Api.Rankings;
    using Api.Benchmarks;
    using Api.Status;
    using Api.Health;
    using Api.Request;
    using Api.FindMatches;
    using Api.Hero;
    using Api.HeroStats;
    using Api.Leagues;
    using Api.Teams;
    using Api.Replay;
    using Api.Records;
    using Api.Live;
    using Api.Scenarios;
    using Api.Schema;
    using Api.Constants;
    public class OpenDota
    {
        public OpenDota()
        {
            var request = new RequestHandler();
            Matches = new MatchesEndpoint(request);
            PlayersByRank = new PlayersByRankEndpoint(request);
            Player = new PlayerEndpoint(request);
            ProPlayer = new ProPlayerEndpoint(request);
            ProMatch = new ProMatchEndpoint(request);
            PublicMatch = new PublicMatchEndpoint(request);
            ParsedMatch = new ParsedMatchEndpoint(request);
            Metadata = new MetadataEndpoint(request);
            Distributions = new DistributionsEndpoint(request);
            Search = new SearchEndpoint(request);
            Rankings = new RankingsEndpoint(request);
            Benchmarks = new BenchmarksEndpoint(request);
            Status = new StatusEndpoint(request);
            Health = new HealthEndpoint(request);
            Request = new RequestEndpoint(request);
            FindMatches = new FindMatchesEndpoint(request);
            Hero = new HeroEndpoint(request);
            HeroStats = new HeroStatsEndpoint(request);
            Leagues = new LeaguesEndpoint(request);
            Teams = new TeamsEndpoint(request);
            Replays = new ReplayEndpoint(request);
            Records = new RecordEndpoint(request);
            Live = new LiveEndpoint(request);
            Scenarios = new ScenariosEndpoint(request);
            Schema = new SchemaEndpoint(request);
            Constants = new ConstantsEndpoint(request);
        }

        public readonly IMatchesEndpoint Matches;
        public readonly IPlayersByRankEndpoint PlayersByRank;
        public readonly IPlayerEndpoint Player;
        public readonly IProPlayerEndpoint ProPlayer;
        public readonly IProMatchEndpoint ProMatch;
        public readonly IPublicMatchEndpoint PublicMatch;
        public readonly IParsedMatchEndpoint ParsedMatch;
        public readonly IMetadataEndpoint Metadata;
        public readonly IDistributionsEndpoint Distributions;
        public readonly ISearchEndpoint Search;
        public readonly IRankingsEndpoint Rankings;
        public readonly IBenchmarksEndpoint Benchmarks;
        public readonly IStatusEndpoint Status;
        public readonly IHealthEndpoint Health;
        public readonly IRequestEndpoint Request;
        public readonly IFindMatchesEndpoint FindMatches;
        public readonly IHeroEndpoint Hero;
        public readonly IHeroStatsEndpoint HeroStats;
        public readonly ILeaguesEndpoint Leagues;
        public readonly ITeamsEndpoint Teams;
        public readonly IReplayEndpoint Replays;
        public readonly IRecordEndpoint Records;
        public readonly ILiveEndpoint Live;
        public readonly IScenariosEndpoint Scenarios;
        public readonly ISchemaEndpoint Schema;
        public readonly IConstantsEndpoint Constants;
    }
}