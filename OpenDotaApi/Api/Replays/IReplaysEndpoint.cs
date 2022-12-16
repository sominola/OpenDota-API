using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Replays
{
    using Model;
    public interface IReplaysEndpoint
    {
        Task<List<Replay>> GetReplayDataAsync(List<long> matchIds = null, CancellationToken? token = default);
    }
}