namespace OpenDotaApi
{
    using Api.Player;
    public class OpenDota
    {

        public OpenDota()
        {
            var request = new RequestHandler();
            Player = new PlayerService(request);
        }
        public readonly IPlayerService Player;
    }
}