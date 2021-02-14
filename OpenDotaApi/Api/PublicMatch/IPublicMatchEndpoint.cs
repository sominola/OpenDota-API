using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.PublicMatch
{
    using Model;
    public interface IPublicMatchEndpoint
    {
        Task<List<PublicMatch>> GetListPublicMatchesAsync();
    }
}