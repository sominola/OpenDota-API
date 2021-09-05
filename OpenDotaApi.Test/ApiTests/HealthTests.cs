using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class HealthTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HealthTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetServiceHealthDataAsync()
        {
            var data = await _openDota.Health.GetServiceHealthDataAsync();
            Assert.Equal(0, data.SteamApi.Metric);
        }
    }
}