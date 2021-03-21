using APIHome;
using APIHome.Data;
using HAA.Data;
using Unity;

namespace HAA.Service
{

    public static class DependencyInjection
    {

        public static void InjectTypes()
        {
            UnityHelper.UnityContainer.RegisterType<ILoggerRepo, LoggerRepo>();
            UnityHelper.UnityContainer.RegisterType<IHAAService, HAAService>();
            UnityHelper.UnityContainer.RegisterType<ILogService, LogService>();
            UnityHelper.UnityContainer.RegisterType<IHAAApi, HAAApi>();
        }

    }
}