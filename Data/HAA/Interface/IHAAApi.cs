namespace HAA.Data
{
    public interface IHAAApi
    {
        string LookupName(decimal Lat, decimal Lang);
        string[] GetLookupNameApiParams(string Name);
    }
}