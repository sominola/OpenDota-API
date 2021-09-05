using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ProMatches
{
    using Model;

    public interface IProMatchesEndpoint
    {
        Task<List<ProMatch>> GetListProMatchesAsync(long? lessThanMatchId = null);
    }
}