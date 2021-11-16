using System;
using OpenDotaApi.Utilities;
using Xunit;


namespace OpenDotaApi.Test
{
    [Collection("RequestHandlerTest")]
    public class RequestHandlerTests : IDisposable
    {
        private readonly RequestHandler _request;

        public RequestHandlerTests() => _request = new RequestHandler();

        [Fact]
        public async void TestGetResponseAsync()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => { await _request.GetResponseAsync(""); });
        }

        [Fact]
        public async void TestPostRequestAsync()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => { await _request.PostRequestAsync(""); });
        }

        [Fact]
        public async void TestWhenLimitReachedLimit()
        {
            var exception = await Record.ExceptionAsync(async () =>
            {
                for (int i = 1; i < 70; i++)
                {
                    var response = await _request.GetResponseAsync("https://api.opendota.com/api/players/164583656/wl");
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.ReasonPhrase + " " + response.StatusCode);
                }
            });
            Assert.Null(exception);
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}