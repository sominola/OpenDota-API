using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class PublicMatchTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public PublicMatchTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task GetListPublicMatchesAsync()
        {
            var data = await _openDota.PublicMatches.GetListPublicMatchesAsync();
            Assert.NotEmpty(data);

            var data1 = await _openDota.PublicMatches.GetListPublicMatchesAsync(1);
            Assert.NotEmpty(data1);
            
            var data2 = await _openDota.PublicMatches.GetListPublicMatchesAsync(1,4500,6163720706);
            Assert.NotEmpty(data2);
        }
    }
}