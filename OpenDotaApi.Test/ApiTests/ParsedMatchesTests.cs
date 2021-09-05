using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class ParsedMatchesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ParsedMatchesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetListParsedMatches()
        {
            var data = await _openDota.ParsedMatches.GetListParsedMatches(6160273077);
            Assert.Equal(6160272902, data.First().MatchId);
        }
        
        [Fact]
        public async void TestGetListParsedMatchesWithoutQuery()
        {
            var data = await _openDota.ParsedMatches.GetListParsedMatches();
            Assert.NotEmpty(data);
        }
    }
}