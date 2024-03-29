using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class RequestTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public RequestTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetParseRequestStateAsync()
        {
            var data = await _openDota.Request.GetParseRequestStateAsync(154864692);
            Assert.Null(data);
            
            var data1 = await _openDota.Request.SubmitNewParseRequestAsync(154864692);
            Assert.NotNull(data1);
        }
    }
}