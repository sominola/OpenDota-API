using System.Threading.Tasks;

namespace OpenDotaApi.Api.Player
{
    using Model;
    public class PlayerService: IPlayerService
    {
        private readonly RequestHandler _request;
        public PlayerService(RequestHandler requestHandler)
        {
            this._request = requestHandler;
        }
        public async Task<Player> GetPlayerById(long playerId)
        {
           return await _request.GetResponseAsync<Player>($"players/{playerId}");
        }

        public async Task<WinLoss> GetWinLossById(long playerId,PlayerParameters parameters)
        {
            return await _request.GetResponseAsync<WinLoss>($"players/{playerId}/wl?"+parameters.GetParamaters());
        }
    }
}