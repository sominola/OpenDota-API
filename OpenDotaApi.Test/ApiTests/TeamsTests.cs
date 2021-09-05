using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class TeamsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public TeamsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetTeamsAsync()
        {
            var data = await _openDota.Teams.GetTeamsAsync();
            Assert.Equal(1883502, data.First().TeamId);
        }

        [Fact]
        public async void TestGetTeamByIdAsync()
        {
            var data = await _openDota.Teams.GetTeamByIdAsync(1883502);
            Assert.Equal(1883502, data.TeamId);

        }
        
        [Fact]
        public async void TestGetMatchesAsync()
        {
            var data = await _openDota.Teams.GetMatchesAsync(1883502);
           Assert.NotEmpty(data);

        }
        
        [Fact]
        public async void TestGetPlayersAsync()
        {
            var data = await _openDota.Teams.GetPlayersAsync(1883502);
            Assert.False(data.First().IsCurrentTeamMember);
        }
        
        [Fact]
        public async void TestGetHeroesAsync()
        {
            var data = await _openDota.Teams.GetHeroesAsync(1883502);
            Assert.Equal(20,data.First().HeroId);
        }
    }
}