using Unity;

namespace APIHome.Services
{

    public static class DependencyInjection
    {

        public static void InjectTypes()
        {
            HAA.Service.DependencyInjection.InjectTypes();
        }

    }
}