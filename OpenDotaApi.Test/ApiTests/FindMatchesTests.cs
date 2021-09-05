using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class FindMatchesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public FindMatchesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestFindsRecentMatchesByHeroesPlayedAsync()
        {
            var teamA = new List<int>()
            {
                1,2,21,4,5
            };

            var teamB = new List<int>
            {
                14
            };

            var data = await _openDota.FindMatches.FindsRecentMatchesByHeroesPlayedAsync(teamA,teamB);
            Assert.Contains(14, data.First().TeamA);
        }
    }
}