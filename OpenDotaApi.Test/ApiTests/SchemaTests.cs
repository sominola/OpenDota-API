using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace OpenDotaApi.Test.ApiTests
{
    [Collection("ApiTest")]
    public class SchemaTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public SchemaTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async Task TestGetDataSchema()
        {
            var data = await _openDota.Schema.GetDataSchemaAsync();
            Assert.Equal("account_id", data.First().ColumnName);
        }
    }
}