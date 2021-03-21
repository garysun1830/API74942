using APIHome;
using APIHome.Data;
using System;
using Unity;

namespace HAA.Service
{
    public class LogService : ILogService
    {
        private readonly ILoggerRepo repo;

        public LogService()
        {
            repo = UnityHelper.UnityContainer.Resolve<ILoggerRepo>();
        }

        public void Log(string Message)
        {
            repo.Log(Message);
        }

        public void Log(Exception e)
        {
            Log(e.Message);
        }

        public void LogApiCount(string URL, string Name)
        {
            repo.LogApiCount(URL, Name);
        }
        public int GetApiCount(string URL, string Name)
        {
            return repo.GetApiCount(URL, Name);
        }


    }
}