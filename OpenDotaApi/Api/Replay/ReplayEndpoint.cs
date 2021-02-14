using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Replay
{
    using Model;

    public class ReplayEndpoint : IReplayEndpoint
    {
        private readonly RequestHandler _request;

        public ReplayEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Replay>> GetReplayDataAsync(List<long> matchIds)
        {
            string parameters = "";
            if (matchIds != null)
                foreach (var value in matchIds)
                    parameters += $"&match_id={value}";

            return await _request.GetResponseAsync<List<Replay>>("replays", parameters);
        }
    }
}