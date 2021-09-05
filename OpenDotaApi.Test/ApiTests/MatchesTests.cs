using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class MatchesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public MatchesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetMatchAsync()
        {
            var data = await _openDota.Matches.GetMatchAsync(6160273077);
            Assert.Equal(273, data.Cluster);
        }
    }
}