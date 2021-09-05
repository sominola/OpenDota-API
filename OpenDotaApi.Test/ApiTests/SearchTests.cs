using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class SearchTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public SearchTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetListPlayersByNameAsync()
        {
            var data = await _openDota.Search.GetListPlayersByNameAsync("Nikita");
            Assert.Equal("Nikita", data.First().Personaname);
        }
    }
}