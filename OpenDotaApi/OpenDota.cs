using OpenDotaApi.Api.ProMatch;

namespace OpenDotaApi
{
    using Utilities;
    using Api.Match;
    using Api.Player;
    using Api.PlayersByRank;
    using Api.ProPlayer;
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
        }

        public readonly IMatchesEndpoint Matches;
        public readonly IPlayersByRankEndpoint PlayersByRank;
        public readonly IPlayerEndpoint Player;
        public readonly IProPlayerEndpoint ProPlayer;
        public readonly IProMatchEndpoint ProMatch;
    }
}