using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Scenarios
{
    using Model;

    public interface IScenariosEndpoint
    {
        Task<List<ItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null);
        Task<List<LaneRoles>> GetWinRateForHeroes(HeroLaneRole? role = null, int? heroId = null);
        Task<List<TeamScenarios>> GetTeamScenarios(Scenarios? scenario = null);
    }
}