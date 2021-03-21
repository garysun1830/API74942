using APIHome;
using HAA.Data;
using System.Collections.Generic;
using Unity;
using Unity.Resolution;

namespace HAA.Service
{
    public class HAAService : IHAAService
    {

        private readonly IHAAApi api;
        private readonly ILogService logService;

        public HAAService()
        {
            api = UnityHelper.UnityContainer.Resolve<IHAAApi>();
            logService = UnityHelper.UnityContainer.Resolve<ILogService>();
        }

        public int GetCount(string RequestName)
        {
            return logService.GetApiCount(RequestName);
        }

        public string LookupName(decimal Lat, decimal Lang)
        {
            logService.LogApiCount("LookupName");
            return api.LookupName(Lat, Lang);
        }


    }
}