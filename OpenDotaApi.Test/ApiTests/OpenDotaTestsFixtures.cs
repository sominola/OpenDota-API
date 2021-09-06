using System;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Test.ApiTests
{
    public class OpenDotaTestsFixtures : IDisposable
    {
        public OpenDotaTestsFixtures()
        {
            RequestHandler = new RequestHandler();
            OpenDota = new OpenDota(request: RequestHandler);
        }

        public OpenDota OpenDota { get; private set; }
        public RequestHandler RequestHandler { get; private set; }

        public void Dispose()
        {
            OpenDota?.Dispose();
        }
    }
}