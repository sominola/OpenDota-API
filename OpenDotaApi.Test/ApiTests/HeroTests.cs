using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class HeroTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public HeroTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetDataAsync()
        {
            var data = await _openDota.Heroes.GetDataAsync();
            Assert.Equal(1, data.First().Id);
        }
        
        [Fact]
        public async void TestGetRecentMatchesAsync()
        {
            var data = await _openDota.Heroes.GetRecentMatchesAsync(1);
            Assert.NotEmpty(data);
        }

        [Fact]
        public async void TestGetMatchupsAsync()
        {
            var data = await _openDota.Heroes.GetMatchUpsAsync(1);
            Assert.Equal(126, data.First().HeroId);
        }

        [Fact]
        public async void TestGetDurationsAsync()
        {
            var data = await _openDota.Heroes.GetDurationsAsync(1);
            Assert.Equal(5700, data.First().DurationBin);
        }

        [Fact]
        public async void TestGetPlayersAsync()
        {
            var data = await _openDota.Heroes.GetPlayersAsync(1);
            Assert.Equal(21289303, data.First().AccountId);

        }

        [Fact]
        public async void TestGetItemPopularity()
        {
            var data = await _openDota.Heroes.GetItemPopularityAsync(1);
            Assert.Equal(96, data.StartGameItems.First().Value);
        }
    }
}