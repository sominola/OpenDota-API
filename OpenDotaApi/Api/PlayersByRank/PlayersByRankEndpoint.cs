using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.PlayersByRank
{
    using Model;
    public class PlayersByRankEndpoint : IPlayersByRankEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public PlayersByRankEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }
        
        public async Task<List<PlayersByRank>> GetListPlayersByRankAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<PlayersByRank>>($"playersByRank", null,token);

    }
}