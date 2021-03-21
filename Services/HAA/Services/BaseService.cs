using APIHome;
using System;
using Unity;

namespace HAA.Service
{
    public class BaseService
    {

        protected void ExecuteService(Action act)
        {
            try
            {
                act();
            }
            catch (Exception ex)
            {
                ILogService svc = UnityHelper.UnityContainer.Resolve<ILogService>();
                svc.Log(ex);
                throw ex;
            }
        }

    }
}