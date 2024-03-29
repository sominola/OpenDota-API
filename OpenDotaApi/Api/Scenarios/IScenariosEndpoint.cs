using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Scenarios
{
    using Model;

    public interface IScenariosEndpoint
    {
        Task<List<ItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null,
            CancellationToken? token = default);

        Task<List<LaneRoles>> GetWinRateForHeroesAsync(HeroLaneRole? role = null, int? heroId = null,
            CancellationToken? token = default);

        Task<List<TeamScenarios>> GetTeamScenariosAsync(Enums.Scenarios? scenario = null,
            CancellationToken? token = default);
    }
}