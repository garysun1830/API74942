using HAA.Service;
using System;
using System.Web.Http;
using Unity;

namespace APIHome.Controllers
{
    public class BaseController : ApiController
    {
        /// <summary>
        /// the base method for API methods
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        protected Exception DoService(Action act)
        {
            try
            {
                act();
                return null;
            }
            catch (Exception ex)
            {
                ILogService svc = UnityHelper.UnityContainer.Resolve<ILogService>();
                svc.Log(ex);
                return new Exception(ex.Message.Replace("\\n", "").Replace("\\r", ""));
            }
        }

    }
}

