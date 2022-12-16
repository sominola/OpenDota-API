using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ProPlayers
{
    using Model;

    public class ProPlayersEndpoint : IProPlayersEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public ProPlayersEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }
        
        public async Task<List<ProPlayer>> GetListProPlayersAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<ProPlayer>>($"proPlayers",null,token);
    }
}