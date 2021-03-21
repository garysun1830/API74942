using System;
using System.Web.Http;

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
                return new Exception(ex.Message.Replace("\\n", "").Replace("\\r", ""));
            }
        }

    }
}
