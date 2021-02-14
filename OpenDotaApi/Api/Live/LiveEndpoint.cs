using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Live
{
    using Model;
    public class LiveEndpoint: ILiveEndpoint
    {
        private readonly RequestHandler _request;

        public LiveEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Live>> GetProLiveGamesAsync() =>
            await _request.GetResponseAsync<List<Live>>("live");

    }
}