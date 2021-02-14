using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Leagues
{
    using Model;
    public class LeaguesEndpoint : ILeaguesEndpoint
    {
        private readonly RequestHandler _request;

        public LeaguesEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Leagues>> GetLeaguesAsync() =>
            await _request.GetResponseAsync<List<Leagues>>("leagues");
    }
}