namespace APIHome.Data
{
    public interface ILoggerRepo
    {
        void Log(string Message);
        void LogApiCount(string URL, string Name);
        int GetApiCount(string URL, string Name);
    }
}