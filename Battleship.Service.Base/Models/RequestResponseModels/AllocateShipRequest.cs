using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Battleship.Service.Base.Models.RequestResponseModels
{
    public class AllocateShipRequest
    {
        public KeyValuePair<int, int> BattleShip { get; set; }
        public required KeyValuePair<int, int>[] DestroyerShip { get; set; }
    }
}
