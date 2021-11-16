using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class PlayersByRankTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public PlayersByRankTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetListPlayersByRankAsync()
        {
            var data = await _openDota.PlayersByRank.GetListPlayersByRankAsync();
            Assert.Equal(80, data.First().Rating);
        }
    }
}