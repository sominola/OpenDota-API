using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class MetadataTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public MetadataTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetMetadataAsync()
        {
            var data = await _openDota.Metadata.GetMetadataAsync();
            Assert.Equal("pos_chat_1min",data.Scenarios.TeamScenariosQueryParams.First());
        }
    }
}