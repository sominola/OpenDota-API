using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class MetadataTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public MetadataTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetMetadataAsync()
        {
            var data = await _openDota.Metadata.GetMetadataAsync();
            Assert.Equal("pos_chat_1min",data.Scenarios.TeamScenariosQueryParams.First());
        }
    }
}