using APIHome;
using System;
using Unity;

namespace HAA.Service
{
    public class BaseService
    {
        /// <summary>
        /// the base method for the service methods
        /// </summary>
        /// <param name="act"></param>
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