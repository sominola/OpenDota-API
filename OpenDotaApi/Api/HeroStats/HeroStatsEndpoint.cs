using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.HeroStats
{
    using Model;

    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private readonly JsonFormatter _formatter;

        public HeroStatsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<HeroStats>> GetHeroStatsAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<HeroStats>>("heroStats", null, token);
    }
}