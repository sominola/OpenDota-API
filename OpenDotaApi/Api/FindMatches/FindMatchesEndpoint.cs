using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.FindMatches
{
    using Model;

    public class FindMatchesEndpoint : IFindMatchesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public FindMatchesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
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
            return await _formatter.DeserializeAsync<List<FindMatches>>("findMatches" , parameters);
        }
    }
}