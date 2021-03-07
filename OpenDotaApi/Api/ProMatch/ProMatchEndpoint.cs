using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ProMatch
{
    using Model;

    public class ProMatchEndpoint : IProMatchEndpoint
    {
        private readonly RequestHandler _request;

        public ProMatchEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<ProMatch>> GetListProMatchesAsync(long? lessThanMatchId = null) =>
            await _request.GetResponseAsync<List<ProMatch>>("proMatches", lessThanMatchId == null ? "" : $"&less_than_match_id={lessThanMatchId}");
    }
}