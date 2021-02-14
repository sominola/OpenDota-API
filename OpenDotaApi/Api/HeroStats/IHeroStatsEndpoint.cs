using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.HeroStats
{
    using Model;
    public interface IHeroStatsEndpoint
    {
        Task<List<HeroStats>> GetHeroStatsAsync();
    }
}