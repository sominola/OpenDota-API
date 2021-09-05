using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ProPlayers
{
    using Model;

    public interface IProPlayersEndpoint
    {
        Task<List<ProPlayer>> GetListProPlayersAsync();
    }
}