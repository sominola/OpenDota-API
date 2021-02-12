using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ProPlayer
{
    using Model;
    public class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private readonly RequestHandler _request;

        public ProPlayerEndpoint(RequestHandler request)
        {
            _request = request;
        }
        public async Task<List<ProPlayer>> GetListProPlayersAsync() =>
            await _request.GetResponseAsync<List<ProPlayer>>($"proPlayers");
    }
}