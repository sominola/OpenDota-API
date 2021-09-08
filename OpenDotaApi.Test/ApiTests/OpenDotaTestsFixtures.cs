using System;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Test.ApiTests
{
    public class OpenDotaTestsFixtures : IDisposable
    {
        public OpenDotaTestsFixtures()
        {
            OpenDota = new OpenDota();
        }

        public OpenDota OpenDota { get; private set; }

        public void Dispose()
        {
            OpenDota?.Dispose();
        }
    }
}