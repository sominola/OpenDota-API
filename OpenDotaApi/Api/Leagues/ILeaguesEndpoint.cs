using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Leagues
{
    using Model;
    public interface ILeaguesEndpoint
    {
        Task<List<Leagues>> GetLeaguesAsync();
    }
}