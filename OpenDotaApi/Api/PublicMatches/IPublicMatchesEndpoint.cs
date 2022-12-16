using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.PublicMatches
{
    using Model;
    public interface IPublicMatchesEndpoint
    {
        Task<List<PublicMatch>> GetListPublicMatchesAsync(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null, CancellationToken? token = default);
    }
}