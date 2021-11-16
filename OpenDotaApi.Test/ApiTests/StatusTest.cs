using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class StatusTest: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public StatusTest(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetServiceStatisticsAsync()
        {
            var data = await _openDota.Status.GetServiceStatisticsAsync();
            Assert.True(186473 <= data.UserPlayers);
        }
    }
}