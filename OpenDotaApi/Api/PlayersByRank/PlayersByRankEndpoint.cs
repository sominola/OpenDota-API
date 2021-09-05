using System.Collections.Generic;
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
        
        public async Task<List<PlayersByRank>> GetListPlayersByRankAsync() =>
            await _formatter.DeserializeAsync<List<PlayersByRank>>($"playersByRank");

    }
}