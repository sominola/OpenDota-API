using System;
using OpenDotaApi.Utilities;
using Xunit;

namespace OpenDotaApi.Test
{
    public class JsonFormatterTests : IDisposable
    {
        private readonly JsonFormatter _formatter;
        public JsonFormatterTests() => _formatter = new JsonFormatter(new RequestHandler());

        [Fact]
        public async void TestIsNullWhenStatusCodeNotSuccess()
        {
            var data = await _formatter.DeserializeAsync<object>("test");
            Assert.Null(data);
        }

        [Fact]
        public async void TestThrowExceptionWhenNull()
        {
            await Assert.ThrowsAsync<NullReferenceException>(async () =>
                {
                    await _formatter.DeserializeAsync<object>(null);
                }
            );
        }

        public void Dispose()
        {
            _formatter?.Dispose();
        }
    }
}