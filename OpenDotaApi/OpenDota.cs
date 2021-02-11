using OpenDotaApi.Api.PlayersByRank;

namespace OpenDotaApi
{
    using Utilities;
    using Api.Player;
    using Api.Match;
    public class OpenDota
    {
        public OpenDota()
        {
            var request = new RequestHandler();
            Player = new PlayerEndpoint(request);
            Matches = new MatchesEndpoint(request);
            PlayersByRank = new PlayersByRankEndpoint(request);
        }

        public readonly IPlayersByRankEndpoint PlayersByRank;
        public readonly IMatchesEndpoint Matches;
        public readonly IPlayerEndpoint Player;
    }
}