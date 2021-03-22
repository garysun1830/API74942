using HAA.Service;
using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

namespace APIHome.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/haa")]
    public class APIController : BaseController
    {
        /// <summary>
        /// To get the count of the give API method called by the clients
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="RequestName"></param>
        /// <returns></returns>
        [HttpGet, Route("RequestCount/{URL}/{RequestName}")]
        public IHttpActionResult GetRequestCount(string URL, string RequestName)
        {
            int result = 0;
            Exception ret = DoService(() =>
            {
                IHAAService haaSvc = UnityHelper.UnityContainer.Resolve<IHAAService>();
                result = haaSvc.GetApiCount(URL, RequestName);
            });
            if (ret == null) return Ok(result);
            return Ok(ret);
        }

        /// <summary>
        /// To lookup the HAA name with the map postion
        /// </summary>
        /// <param name="Lat"></param>
        /// <param name="Lang"></param>
        /// <returns></returns>
        [HttpGet, Route("LookupName/{Lat}/{Lang}")]
        public IHttpActionResult LookupName(decimal Lat, decimal Lang)
        {
            string result = null;
            Exception ret = DoService(() =>
            {
                IHAAService haaSvc = UnityHelper.UnityContainer.Resolve<IHAAService>();
                result = haaSvc.LookupName(Lat, Lang);
            });
            if (ret == null) return Ok(result);
            return Ok(ret);
        }

    }
}