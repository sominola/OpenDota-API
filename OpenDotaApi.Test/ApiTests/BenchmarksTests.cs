using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class BenchmarksTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public BenchmarksTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetStatValuesByIdHeroAsync()
        {
            var data = await _openDota.Benchmarks.GetStatValuesByIdHeroAsync(1);
            Assert.Equal(1,data.HeroId);
        }
        
    }
}