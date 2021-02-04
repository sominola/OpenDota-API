using System.Threading.Tasks;

namespace OpenDotaApi.Api.Player
{
    using Model;
    public interface IPlayerService
    {
        Task<Player> GetPlayerById(long playerId);
        Task<WinLoss> GetWinLossById(long playerId, PlayerParameters parameters = null);
    }
}