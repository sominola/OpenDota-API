using System;
using OpenDotaApi.Utilities;
using Xunit;

namespace OpenDotaApi.Test
{
    [Collection("JsonFormatterTest")]
    public class JsonFormatterTests : IDisposable
    {
        private readonly JsonFormatter _formatter;
        public JsonFormatterTests() => _formatter = new JsonFormatter(new RequestHandler());

        [Fact]
        public async void TestThrowExceptionWhenNull()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () =>
                {
                    await _formatter.DeserializeAsync<object>(null);
                }
            );
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}