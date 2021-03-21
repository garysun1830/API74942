using System;

namespace HAA.Service
{
    public interface ILogService
    {
        void Log(Exception e);
        void Log(string Message);
        void LogApiCount(string Name);
        int GetApiCount(string Name);
    }
}