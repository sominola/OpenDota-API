namespace OpenDotaApi
{
    using Api.Player;

    public class OpenDota
    {
        public OpenDota()
        {
            var request = new RequestHandler();
            Player = new PlayerEndpoint(request);
        }

        public readonly IPlayerEndpoint Player;
    }
}