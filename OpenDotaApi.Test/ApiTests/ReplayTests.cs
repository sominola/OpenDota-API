using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class ReplayTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ReplayTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetReplayDataAsync()
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