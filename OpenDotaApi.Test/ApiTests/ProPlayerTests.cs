using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ProPlayerTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ProPlayerTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetListProPlayersAsync()
        {
            var data = await _openDota.ProPlayers.GetListProPlayersAsync();
            Assert.NotEmpty(data);
        }
    }
}