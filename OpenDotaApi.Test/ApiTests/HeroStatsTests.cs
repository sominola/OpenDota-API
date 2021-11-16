using System.Linq;
using System.Threading.Tasks;
using OpenDotaApi.Enums;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]public class HeroStatsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HeroStatsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetHeroStatsAsync()
        {
            var data = await _openDota.HeroStats.GetHeroStatsAsync();
            Assert.Equal(HeroRole.Carry, data.First().Roles.First());
        }
    }
}