namespace Battleship.Service.Base.Models.RequestResponseModels
{
    public class GetSystemShipReponse
    {
        public required KeyValuePair<int, int>[] Cordinates { get; set; }
    }
}
