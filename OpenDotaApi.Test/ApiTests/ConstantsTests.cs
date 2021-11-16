using System.Threading.Tasks;
using OpenDotaApi.Enums;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer("OpenDotaApi.Test.Order.DisplayNameOrderer", "OpenDotaApi.Test")]
namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class ConstantsTest: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public ConstantsTest(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetStatValuesByIdHeroAsync()
        {
            var data = await _openDota.Constants.GetGameConstantsAsync(EnumConstants.XpLevel);
            Assert.Contains("230", data);
        }
    }
}