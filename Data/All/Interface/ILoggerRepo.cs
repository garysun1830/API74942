namespace APIHome.Data
{
    public interface ILoggerRepo
    {
        void Log(string Message);
        void LogApiCount(string Name);
        int GetApiCount(string Name);
    }
}