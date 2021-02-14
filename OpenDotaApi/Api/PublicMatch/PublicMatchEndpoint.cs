using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.PublicMatch
{
    using Model;
    public class PublicMatchEndpoint : IPublicMatchEndpoint
    {
        private readonly RequestHandler _request;

        public PublicMatchEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<PublicMatch>> GetListPublicMatchesAsync() =>
            await _request.GetResponseAsync<List<PublicMatch>>("publicMatches");
    }
}