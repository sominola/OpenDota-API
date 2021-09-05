using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class LeaguesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public LeaguesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetLeaguesAsync()
        {
            var data = await _openDota.Leagues.GetLeaguesAsync();
            Assert.NotEmpty(data);
        }
    }
}