namespace HAA.Service
{
    public interface IHAAService
    {
        int GetApiCount(string URL, string RequestName);
        string LookupName(decimal Lat, decimal Lang);
    }
}