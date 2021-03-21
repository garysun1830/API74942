using APIHome;
using HAA.Data;
using System.Collections.Generic;
using System.Configuration;
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

        public int GetApiCount(string URL, string RequestName)
        {
            return logService.GetApiCount(URL, RequestName);
        }

        public string LookupName(decimal Lat, decimal Lang)
        {
            string[] api_names = api.GetLookupNameApiParams("LookupName");
            logService.LogApiCount(api_names[0], api_names[1]);
            return api.LookupName(Lat, Lang);
        }


    }
}