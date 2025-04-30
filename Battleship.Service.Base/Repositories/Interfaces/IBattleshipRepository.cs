using Battleship.Service.Base.Models.RequestResponseModels;

namespace Battleship.Service.Base.Repositories.Interfaces
{
    public interface IBattleshipRepository
    {
        Task<GetSystemShipReponse> GenerateSystemShips();
        Task<bool> LocateShip(AllocateShipRequest request);

        Task<bool> FireSystemShips(FireSystemShipRequest request);

        Task<bool> FireUserShip();
    }
}
