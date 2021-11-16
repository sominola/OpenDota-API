using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class FindMatchesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public FindMatchesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestFindsRecentMatchesByHeroesPlayedAsync()
        {
            var teamA = new List<int>()
            {
                2,21,4,5
            };

            var teamB = new List<int>
            {
                14
            };

            var data = await _openDota.FindMatches.FindsRecentMatchesByHeroesPlayedAsync(teamA,teamB);
            Assert.NotEmpty(data);
        }
    }
}