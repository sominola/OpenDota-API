using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Live
{
    using Model;

    public interface ILiveEndpoint
    {
        Task<List<Live>> GetProLiveGamesAsync();
    }
}