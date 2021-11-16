using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class HeroTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HeroTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetDataAsync()
        {
            var data = await _openDota.Heroes.GetDataAsync();
            Assert.Equal(1, data.First().Id);
        }
        
        [Fact]
        public async Task TestGetRecentMatchesAsync()
        {
            var data = await _openDota.Heroes.GetRecentMatchesAsync(1);
            Assert.NotEmpty(data);
        }

        [Fact]
        public async Task TestGetMatchupsAsync()
        {
            var data = await _openDota.Heroes.GetMatchUpsAsync(1);
            Assert.NotEmpty(data);
        }

        [Fact]
        public async Task TestGetDurationsAsync()
        {
            var data = await _openDota.Heroes.GetDurationsAsync(1);
            Assert.Equal(5700, data.First().DurationBin);
        }

        [Fact]
        public async Task TestGetPlayersAsync()
        {
            var data = await _openDota.Heroes.GetPlayersAsync(1);
            Assert.Equal(21289303, data.First().AccountId);

        }

        [Fact]
        public async Task TestGetItemPopularity()
        {
            var data = await _openDota.Heroes.GetItemPopularityAsync(1);
            Assert.NotNull(data);
        }
    }
}