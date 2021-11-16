using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class TeamsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public TeamsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetTeamsAsync()
        {
            var data = await _openDota.Teams.GetTeamsAsync();
            Assert.NotEmpty(data);
        }

        [Fact]
        public async Task TestGetTeamByIdAsync()
        {
            var data = await _openDota.Teams.GetTeamByIdAsync(1883502);
            Assert.Equal(1883502, data.TeamId);

        }
        
        [Fact]
        public async Task TestGetMatchesAsync()
        {
            var data = await _openDota.Teams.GetMatchesAsync(1883502);
           Assert.NotEmpty(data);

        }
        
        [Fact]
        public async Task TestGetPlayersAsync()
        {
            var data = await _openDota.Teams.GetPlayersAsync(1883502);
            Assert.False(data.First().IsCurrentTeamMember);
        }
        
        [Fact]
        public async Task TestGetHeroesAsync()
        {
            var data = await _openDota.Teams.GetHeroesAsync(1883502);
            Assert.Equal(20,data.First().HeroId);
        }
    }
}