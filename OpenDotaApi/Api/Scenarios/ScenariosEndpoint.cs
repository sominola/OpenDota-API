using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Scenarios
{
    using Model;

    public class ScenariosEndpoint : IScenariosEndpoint
    {
        private readonly RequestHandler _request;

        public ScenariosEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<ItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null)
        {
            var parameters = item == null ? "" : $"&item={item}";
            parameters += heroId == null ? "" : $"&hero_id={heroId}";
            return await _request.GetResponseAsync<List<ItemTiming>>("scenarios/itemTimings", parameters);
        }

        public async Task<List<LaneRoles>> GetWinRateForHeroes(HeroLaneRole? role = null, int? heroId = null)
        {
            var parameters = role == null ? "" : $"&lane_role={(int) role}";
            parameters += heroId == null ? "" : $"&hero_id={heroId}";
            return await _request.GetResponseAsync<List<LaneRoles>>("scenarios/laneRoles", parameters);
        }

        public async Task<List<TeamScenarios>> GetTeamScenarios(Scenarios? scenario = null)
        {
            var parameters = "";
            switch (scenario)
            {
                case Scenarios.CourierKill:
                    parameters = "courier_kill";
                    break;
                case Scenarios.FirstBlood:
                    parameters = "first_blood";
                    break;
                case Scenarios.NegChat1Min:
                    parameters = "neg_chat_1min";
                    break;
                case Scenarios.PosChat1Min:
                    parameters = "pos_chat_1min";
                    break;
                case null:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(scenario), scenario, null);
            }

            return await _request.GetResponseAsync<List<TeamScenarios>>("scenarios/misc",string.IsNullOrEmpty(parameters)? null:$"&scenario={parameters}");
        }
    }
}