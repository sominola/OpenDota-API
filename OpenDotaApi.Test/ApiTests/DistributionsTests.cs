using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class DistributionsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public DistributionsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetDistributionsAsync()
        {
            var data = await _openDota.Distributions.GetDistributionsAsync();
            Assert.Equal(36, data.Ranks.RowCount);
        }
    }
}