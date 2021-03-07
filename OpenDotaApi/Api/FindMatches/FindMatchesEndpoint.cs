using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.FindMatches
{
    using Model;

    public class FindMatchesEndpoint : IFindMatchesEndpoint
    {
        private readonly RequestHandler _request;

        public FindMatchesEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<FindMatches>> FindsRecentMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null)
        {
            var parameters = "";
            if (teamA != null)
                foreach (var val in teamA)
                    parameters += $"&teamA={val}";
            if (teamB != null)
                foreach (var val in teamB)
                    parameters += $"&teamB={val}";
            return await _request.GetResponseAsync<List<FindMatches>>("findMatches" , parameters);
        }
    }
}