using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ProPlayer
{
    using Model;
    public interface IProPlayerEndpoint
    {
        Task<List<ProPlayer>> GetListProPlayersAsync();
    }
}