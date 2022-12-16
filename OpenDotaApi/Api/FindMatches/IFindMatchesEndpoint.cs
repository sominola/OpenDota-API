using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.FindMatches
{
    using Model;
    public interface IFindMatchesEndpoint
    {
        Task<List<FindMatches>> FindsRecentMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null, CancellationToken? token = default);
    }
}