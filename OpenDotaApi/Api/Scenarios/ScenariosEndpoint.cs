using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Enums;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Scenarios
{
    using Model;

    public class ScenariosEndpoint : IScenariosEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public ScenariosEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<ItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null,
            CancellationToken? token = default)
        {
            var parameters = item == null ? "" : $"&item={item}";
            parameters += heroId == null ? "" : $"&hero_id={heroId}";
            return await _formatter.DeserializeAsync<List<ItemTiming>>("scenarios/itemTimings", parameters, token);
        }

        public async Task<List<LaneRoles>> GetWinRateForHeroesAsync(HeroLaneRole? role = null, int? heroId = null,
            CancellationToken? token = default)
        {
            var parameters = role == null ? "" : $"&lane_role={(int) role}";
            parameters += heroId == null ? "" : $"&hero_id={heroId}";
            return await _formatter.DeserializeAsync<List<LaneRoles>>("scenarios/laneRoles", parameters,token);
        }

        public async Task<List<TeamScenarios>> GetTeamScenariosAsync(Enums.Scenarios? scenario = null,
            CancellationToken? token = default)
        {
            var parameters = "";
            switch (scenario)
            {
                case Enums.Scenarios.CourierKill:
                    parameters = "courier_kill";
                    break;
                case Enums.Scenarios.FirstBlood:
                    parameters = "first_blood";
                    break;
                case Enums.Scenarios.NegChat1Min:
                    parameters = "neg_chat_1min";
                    break;
                case Enums.Scenarios.PosChat1Min:
                    parameters = "pos_chat_1min";
                    break;
                case null:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(scenario), scenario, null);
            }

            return await _formatter.DeserializeAsync<List<TeamScenarios>>("scenarios/misc",
                string.IsNullOrEmpty(parameters)? null:$"&scenario={parameters}", token);
        }
    }
}