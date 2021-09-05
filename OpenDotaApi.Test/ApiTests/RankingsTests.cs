using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class RankingsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public RankingsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetTopPlayersByHero()
        {
            var data = await _openDota.Rankings.GetTopPlayersByHeroAsync(1);
            Assert.Equal(80, data.ListRankings.First().RankTier);
        }
    }
}