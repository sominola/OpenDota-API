using System;
using System.Linq;
using System.Threading.Tasks;
using OpenDotaApi.Enums;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ScenariosTests : IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ScenariosTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetWinRateForCertainItemTimingsOnHeroesAsync()
        {
            var data = await _openDota.Scenarios.GetWinRateForCertainItemTimingsOnHeroesAsync("armlet", 1);
            Assert.Equal(1, data.First().HeroId);
        }

        [Fact]
        public async Task TestGetWinRateForHeroes()
        {
            var data = await _openDota.Scenarios.GetWinRateForHeroesAsync(HeroLaneRole.Mid, 1);
            Assert.Equal(2, data.First().LaneRole);
        }

        [Fact]
        public async Task TestGetTeamScenarios()
        {
            var data = await _openDota.Scenarios.GetTeamScenariosAsync(Scenarios.FirstBlood);
            Assert.Equal("first_blood", data.First().Scenario);

            var data1 = await _openDota.Scenarios.GetTeamScenariosAsync(Scenarios.CourierKill);
            Assert.Equal("courier_kill", data1.First().Scenario);

            var data2 = await _openDota.Scenarios.GetTeamScenariosAsync(Scenarios.NegChat1Min);
            Assert.Equal("neg_chat_1min", data2.First().Scenario);

            var data3 = await _openDota.Scenarios.GetTeamScenariosAsync(Scenarios.PosChat1Min);
            Assert.Equal("pos_chat_1min", data3.First().Scenario);

            var data4 = await _openDota.Scenarios.GetTeamScenariosAsync();
            Assert.NotEmpty(data4);


            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(
                async () => await _openDota.Scenarios.GetTeamScenariosAsync((Scenarios) 10)
            );
        }
    }
}