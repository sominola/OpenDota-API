using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class LiveTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public LiveTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void GetProLiveGamesAsync()
        {
            var data = await _openDota.Live.GetProLiveGamesAsync();
            Assert.NotEmpty(data);
        }
    }
}