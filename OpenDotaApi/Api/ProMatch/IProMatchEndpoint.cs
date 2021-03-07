using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ProMatch
{
    using Model;
    public interface IProMatchEndpoint
    {
        Task<List<ProMatch>> GetListProMatchesAsync(long? lessThanMatchId = null);
    }
}