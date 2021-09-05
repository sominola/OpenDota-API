using System.Collections.Generic;
using System.Linq;
using OpenDotaApi.Api.Players;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class PlayerTests : IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public PlayerTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetPlayerAsync()
        {
            var data = await _openDota.Players.GetPlayerAsync(164583656);
            Assert.Equal("UA", data.Profile.LocCountryCode);
        }

        [Fact]
        public async void TestGetWinLossAsync()
        {
            var data = await _openDota.Players.GetWinLossAsync(164583656);
            Assert.True(1270 <= data.Win);
        }

        [Fact]
        public async void TestGetRecentMatchesAsync()
        {
            var data = await _openDota.Players.GetRecentMatchesAsync(164583656);
            Assert.Equal(273, data.First().Cluster);
        }

        [Fact]
        public async void TestGetMatchesAsync()
        {
            var data = await _openDota.Players.GetMatchesAsync(164583656);
            Assert.Null(data.First().Version);
            Assert.Equal(0, data.First().LeaverStatus);

            var playerParameters = new PlayerParameters
            {
                IncludedAccountId = new List<int>()
                {
                    196346369
                }
            };

            var data1 = await _openDota.Players.GetMatchesAsync(164583656, playerParameters);
            Assert.Equal(6149167716, data1.First().MatchId);
        }

        [Fact]
        public async void TestGetHeroesAsync()
        {
            var data = await _openDota.Players.GetHeroesAsync(164583656);
            Assert.Equal(101, data.First().HeroId);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42, 89
                }
            };

            var data1 = await _openDota.Players.GetHeroesAsync(164583656, playerParameters);

            Assert.Equal(89, data1.First().HeroId);
        }

        [Fact]
        public async void TestGetPeersAsync()
        {
            var data = await _openDota.Players.GetPeersAsync(164583656);
            Assert.Equal(984697773, data.First().AccountId);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetPeersAsync(164583656, playerParameters);
            Assert.Equal(984697773, data1.First().AccountId);
        }

        [Fact]
        public async void TestGetProAsync()
        {
            var data = await _openDota.Players.GetProAsync(113995822);
            Assert.Equal(117483894, data[1].AccountId);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetPeersAsync(113995822, playerParameters);
            Assert.Equal(90125566, data1[2].AccountId);
        }

        [Fact]
        public async void TestGetTotalsAsync()
        {
            var data = await _openDota.Players.GetTotalsAsync(113995822);
            Assert.Equal("kills", data.First().Field);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetTotalsAsync(113995822, playerParameters);
            Assert.True(898 <= data1.First().N);
        }

        [Fact]
        public async void TestGetHistogramsAsync()
        {
            var data = await _openDota.Players.GetHistogramsAsync(113995822, "kills");
            Assert.NotEmpty(data);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetHistogramsAsync(113995822, "kills", playerParameters);
            Assert.NotEmpty(data1);
        }

        [Fact]
        public async void TestGetWardMapAsync()
        {
            var data = await _openDota.Players.GetWardMapAsync(113995822);
            Assert.Equal(1, data.Obs.First().Value.First().Value);

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetWardMapAsync(113995822, playerParameters);
            Assert.Equal(1, data1.Sen.First().Value.First().Value);
        }

        [Fact]
        public async void TestGetWordCloudAsync()
        {
            var data = await _openDota.Players.GetWordCloudAsync(113995822);
            Assert.True(data.AllWordCounts.ContainsKey("чел"));

            var playerParameters = new PlayerParameters
            {
                WithHeroId = new List<int>
                {
                    42
                }
            };

            var data1 = await _openDota.Players.GetWordCloudAsync(113995822, playerParameters);
            Assert.True(data1.AllWordCounts.ContainsKey("гуль"));
        }

        [Fact]
        public async void TestGetRatingsAsync()
        {
            var data = await _openDota.Players.GetRatingsAsync(113995822);
            Assert.Equal(113995822, data.First().AccountId);
        }

        [Fact]
        public async void TestGetRankingsAsync()
        {
            var data = await _openDota.Players.GetRankingsAsync(113995822);
            Assert.Equal(1, data.First().PercentRank);
        }

        [Fact]
        public async void TestRefreshPlayerMatchHistory()
        {
            var data = await _openDota.Players.RefreshPlayerMatchHistoryAsync(113995822);

            Assert.True(data);
        }
    }
}