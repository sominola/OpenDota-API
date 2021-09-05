using System.Linq;
using OpenDotaApi.Enums;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class HeroStatsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HeroStatsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetHeroStatsAsync()
        {
            var data = await _openDota.HeroStats.GetHeroStatsAsync();
            Assert.Equal(HeroRole.Carry, data.First().Roles.First());
        }
    }
}