using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ProMatchTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ProMatchTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetListPlayersByRankAsync()
        {
            var data = await _openDota.ProMatches.GetListProMatchesAsync();
            Assert.NotEmpty(data);

            var data1 = await _openDota.ProMatches.GetListProMatchesAsync(6160754362);
            Assert.NotEmpty(data1);
        }
    }
}