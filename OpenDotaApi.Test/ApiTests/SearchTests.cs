using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class SearchTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public SearchTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetListPlayersByNameAsync()
        {
            var data = await _openDota.Search.GetListPlayersByNameAsync("Nikita");
            Assert.Equal("Nikita", data.First().Personaname);
        }
    }
}