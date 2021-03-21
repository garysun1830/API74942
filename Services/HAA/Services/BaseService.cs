using APIHome;
using APIHome.Services;
using System;
using Unity;
using Unity.Resolution;

namespace HAA.Service
{
    public class BaseService
    {

        protected void ExecuteService(Action act)
        {
            ILogService svc = UnityHelper.UnityContainer.Resolve<ILogService>();
            try
            {
                act();
            }
            catch (Exception ex)
            {
                svc.Log(ex);
                throw ex;
            }
        }

    }
}