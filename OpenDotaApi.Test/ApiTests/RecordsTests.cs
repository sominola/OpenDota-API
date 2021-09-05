using OpenDotaApi.Enums;
using Xunit;

namespace OpenDotaApi.Test.ApiTests
{
    public class RecordsTests: IClassFixture<OpenDotaTestsFixtures>
    {
        private readonly OpenDota _openDota;

        public RecordsTests(OpenDotaTestsFixtures fixtures) => _openDota = fixtures.OpenDota;

        [Fact]
        public async void TestGetRecordsByField()
        {
            var data = await _openDota.Records.GetRecordsByFieldAsync(RecordField.Kills);
            Assert.NotEmpty(data);
        }
    }
}