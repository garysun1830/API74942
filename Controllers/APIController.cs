using HAA.Data;
using HAA.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using Unity.Resolution;

namespace APIHome.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/haa")]
    public class APIController : BaseController
    {

        [HttpGet, Route("RequestCount/{RequestName}")]
        public IHttpActionResult GetRequestCount(string RequestName)
        {
            int result = 0;
            Exception ret = DoService(() =>
            {
                IHAAService haaSvc = UnityHelper.UnityContainer.Resolve<IHAAService>();
                result = haaSvc.GetCount(RequestName);
            });
            if (ret == null) return Ok(new { RequestCount = result });
            return Ok(ret);
        }

        [HttpGet, Route("LookupName/{Lat}/{Lang}")]
        public IHttpActionResult LookupName(decimal Lat, decimal Lang)
        {
            string result = null;
            Exception ret = DoService(() =>
            {
                IHAAService haaSvc = UnityHelper.UnityContainer.Resolve<IHAAService>();
                result = haaSvc.LookupName(Lat, Lang);
            });
            if (ret == null) return Ok(new { HAAName = result });
            return Ok(ret);
        }

    }
}