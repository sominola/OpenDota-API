using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ParsedMatchesTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ParsedMatchesTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetListParsedMatches()
        {
            var data = await _openDota.ParsedMatches.GetListParsedMatches(6160273077);
            Assert.Equal(6160272902, data.First().MatchId);
        }
        
        [Fact]
        public async Task TestGetListParsedMatchesWithoutQuery()
        {
            var data = await _openDota.ParsedMatches.GetListParsedMatches();
            Assert.NotEmpty(data);
        }
    }
}