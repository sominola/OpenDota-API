using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class OpenDotaTests:IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public OpenDotaTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestCurrentLimitMinute()
        {
            var data = await _openDota.Players.GetPlayerAsync(164583656);
            Assert.NotNull(_openDota.GetCurrentLimitMinute());
            
        }
        [Fact]
        public async Task TestCurrentLimitMonth()
        {
            var data = await _openDota.Players.GetPlayerAsync(164583656);
            Assert.NotNull(_openDota.GetCurrentLimitMonth());
        }
        
        [Fact]
        public void TestApiKey()
        {
            _openDota.ApiKey = "";
            Assert.Empty(_openDota.ApiKey);
        }
    }
}