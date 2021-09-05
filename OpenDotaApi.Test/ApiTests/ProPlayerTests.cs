using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class ProPlayerTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ProPlayerTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetListProPlayersAsync()
        {
            var data = await _openDota.ProPlayers.GetListProPlayersAsync();
            Assert.NotEmpty(data);
        }
    }
}