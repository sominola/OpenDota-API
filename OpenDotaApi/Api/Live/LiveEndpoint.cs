using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Live
{
    using Model;
    public class LiveEndpoint: ILiveEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public LiveEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Live>> GetProLiveGamesAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Live>>("live", null, token);

    }
}