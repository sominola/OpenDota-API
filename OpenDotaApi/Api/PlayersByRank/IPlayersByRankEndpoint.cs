using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.PlayersByRank
{
    using Model;
    public interface IPlayersByRankEndpoint
    {
        Task<List<PlayersByRank>> GetListPlayersByRankAsync(CancellationToken? token = default);
    }
}