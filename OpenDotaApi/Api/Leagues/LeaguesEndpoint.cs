using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Leagues
{
    using Model;

    public class LeaguesEndpoint : ILeaguesEndpoint
    {
        private readonly JsonFormatter _formatter;

        public LeaguesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Leagues>> GetLeaguesAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Leagues>>("leagues", null, token);
    }
}