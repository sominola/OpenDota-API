using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class StatusTest: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public StatusTest(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetServiceStatisticsAsync()
        {
            var data = await _openDota.Status.GetServiceStatisticsAsync();
            Assert.True(186473 <= data.UserPlayers);
        }
    }
}