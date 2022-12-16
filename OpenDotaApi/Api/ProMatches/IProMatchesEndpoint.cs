using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ProMatches
{
    using Model;

    public interface IProMatchesEndpoint
    {
        Task<List<ProMatch>> GetListProMatchesAsync(long? lessThanMatchId = null,CancellationToken? token = default);
    }
}