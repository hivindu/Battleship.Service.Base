using Battleship.Service.Base.Models.RequestResponseModels;
using Battleship.Service.Base.Repositories.Interfaces;

namespace Battleship.Service.Base.Repositories
{
    public class BattleshipRepository : IBattleshipRepository
    {
        public Task<bool> FireSystemShips(FireSystemShipRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FireUserShip()
        {
            throw new NotImplementedException();
        }

        public Task<GetSystemShipReponse> GenerateSystemShips()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LocateShip(AllocateShipRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
