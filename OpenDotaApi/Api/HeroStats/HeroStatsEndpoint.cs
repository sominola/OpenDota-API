using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.HeroStats
{
    using Model;

    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private readonly RequestHandler _request;

        public HeroStatsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<HeroStats>> GetHeroStatsAsync() =>
            await _request.GetResponseAsync<List<HeroStats>>("heroStats");
    }
}