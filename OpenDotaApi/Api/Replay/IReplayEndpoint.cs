using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Replay
{
    using Model;
    public interface IReplayEndpoint
    {
        Task<List<Replay>> GetReplayDataAsync(List<long> matchIds = null);
    }
}