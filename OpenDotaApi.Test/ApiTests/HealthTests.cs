using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class HealthTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HealthTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetServiceHealthDataAsync()
        {
            var data = await _openDota.Health.GetServiceHealthDataAsync();
            Assert.Equal(0, data.SteamApi.Metric);
        }
    }
}