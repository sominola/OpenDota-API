using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ReplayTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ReplayTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetReplayDataAsync()
        {
            var listMatches = new List<long>
            {
                6160273077
            };
            var data = await _openDota.Replays.GetReplayDataAsync(listMatches);
            Assert.Equal(273, data.First().Cluster);
        }
    }
}