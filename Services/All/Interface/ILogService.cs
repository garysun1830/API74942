using System;

namespace HAA.Service
{
    public interface ILogService
    {
        void Log(Exception e);
        void Log(string Message);
        void LogApiCount(string URL, string Name);
        int GetApiCount(string URL, string Name);
    }
}