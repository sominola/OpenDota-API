using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class RankingsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public RankingsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetTopPlayersByHero()
        {
            var data = await _openDota.Rankings.GetTopPlayersByHeroAsync(1);
            Assert.Equal(80, data.ListRankings.First().RankTier);
        }
    }
}