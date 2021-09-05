using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class ProMatchTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ProMatchTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetListPlayersByRankAsync()
        {
            var data = await _openDota.ProMatches.GetListProMatchesAsync();
            Assert.NotEmpty(data);

            var data1 = await _openDota.ProMatches.GetListProMatchesAsync(6160754362);
            Assert.NotEmpty(data1);
        }
    }
}