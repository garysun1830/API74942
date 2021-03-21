using APIHome;
using APIHome.Data;
using HAA.Data;
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

        public void LogApiCount(string Name)
        {
            repo.LogApiCount(Name);
        }
        public int GetApiCount(string Name)
        {
            return repo.GetApiCount(Name);
        }


    }
}