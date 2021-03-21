namespace HAA.Service
{
    public interface IHAAService
    {
        int GetCount(string RequestName);
        string LookupName(decimal Lat, decimal Lang);
    }
}