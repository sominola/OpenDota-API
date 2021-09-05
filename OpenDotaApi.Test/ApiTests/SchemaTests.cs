using System.Linq;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class SchemaTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public SchemaTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetDataSchema()
        {
            var data = await _openDota.Schema.GetDataSchemaAsync();
            Assert.Equal("account_id", data.First().ColumnName);
        }
    }
}