using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.PlayersByRank
{
    using Model;
    public class PlayersByRankEndpoint : IPlayersByRankEndpoint
    {
        private readonly RequestHandler _request;

        public PlayersByRankEndpoint(RequestHandler requestHandler)
        {
            this._request = requestHandler;
        }
        public async Task<List<PlayersByRank>> GetListPlayersByRankAsync() =>
            await _request.GetResponseAsync<List<PlayersByRank>>($"playersByRank");

    }
}