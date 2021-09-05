using OpenDotaApi.Enums;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class ConstantsTest: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ConstantsTest(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetStatValuesByIdHeroAsync()
        {
            var data = await _openDota.Constants.GetGameConstantsAsync(EnumConstants.XpLevel);
            Assert.Contains("230", data);
        }
    }
}