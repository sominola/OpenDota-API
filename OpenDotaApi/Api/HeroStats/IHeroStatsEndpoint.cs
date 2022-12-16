using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.HeroStats
{
    using Model;
    public interface IHeroStatsEndpoint
    {
        Task<List<HeroStats>> GetHeroStatsAsync(CancellationToken? token = default);
    }
}