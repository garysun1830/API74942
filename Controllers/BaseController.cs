using HAA.Service;
using System;
using System.Web.Http;
using Unity;

namespace APIHome.Controllers
{
    public class BaseController : ApiController
    {
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

