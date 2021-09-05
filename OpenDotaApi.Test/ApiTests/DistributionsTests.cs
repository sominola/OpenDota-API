using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class DistributionsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public DistributionsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetDistributionsAsync()
        {
            var data = await _openDota.Distributions.GetDistributionsAsync();
            Assert.Equal(36, data.Ranks.RowCount);
        }
    }
}