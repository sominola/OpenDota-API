using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class LiveTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public LiveTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task GetProLiveGamesAsync()
        {
            var data = await _openDota.Live.GetProLiveGamesAsync();
            Assert.NotEmpty(data);
        }
    }
}