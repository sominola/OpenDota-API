using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Replays
{
    using Model;
    public class ReplaysEndpoint : IReplaysEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public ReplaysEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Replay>> GetReplayDataAsync(List<long> matchIds, CancellationToken? token = default)
        {
            var parameters = "";
            if (matchIds != null)
                foreach (var value in matchIds)
                    parameters += $"&match_id={value}";

            return await _formatter.DeserializeAsync<List<Replay>>("replays", parameters, token);
        }
    }
}