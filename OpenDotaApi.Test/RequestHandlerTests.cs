using System;
using OpenDotaApi.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace OpenDotaApi.Test
{
    public class RequestHandlerTests : IDisposable
    {
        private readonly RequestHandler _request;
        private readonly ITestOutputHelper _output;

        public RequestHandlerTests(ITestOutputHelper output)
        {
            _request = new RequestHandler();
            _output = output;
        }

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
                    
                    _output.WriteLine($"{i}. Current limit minutes: " + _request.CurrentLimitMinute);
                    _output.WriteLine($"{i}. Current limit month: " + _request.CurrentLimitMonth);
                    _output.WriteLine($"{i}. DateTime: "+ _request.LastDateRequest);
                    _output.WriteLine("");
                }
            });
            Assert.Null(exception);
        }


        public void Dispose()
        {
            _request?.Dispose();
        }
    }
}