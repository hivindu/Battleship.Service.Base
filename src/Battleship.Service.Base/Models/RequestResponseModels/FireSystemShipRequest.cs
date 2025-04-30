namespace Battleship.Service.Base.Models.RequestResponseModels
{
    public class FireSystemShipRequest
    {
        public required KeyValuePair<int, int> ShipLocation { get; set; }
    }
}
