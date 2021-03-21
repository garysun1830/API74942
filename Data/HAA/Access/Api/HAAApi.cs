using System;
using System.Configuration;
using System.Net;
using System.Text.RegularExpressions;

namespace HAA.Data
{
    public class HAAApi : IHAAApi
    {

        private string url_root = null;

        public HAAApi()
        {
            url_root = ConfigurationManager.AppSettings["API_ROOT"];
        }

        private string ConvertPos(decimal value)
        {
            return value >= 0 ? "+" + value.ToString() : value.ToString();
        }

        public string LookupName(decimal Lat, decimal Lang)
        {
            string pos = ConvertPos(Lat) + ConvertPos(Lang);
            string url = string.Format("{0}{1}", url_root, string.Format(ConfigurationManager.AppSettings["API_LOOKUP_AREA_NAME"], pos));
            using (WebClient wc = new WebClient())
            {
                string text = wc.DownloadString(url);
                Match m = Regex.Match(text, "\"CMNTY_HLTH_SERV_AREA_NAME\" *: *\".+");
                if (!m.Success)
                    throw new Exception("Name not found.");
                text = m.Value.Replace("\"CMNTY_HLTH_SERV_AREA_NAME\"", "");
                int i = text.IndexOf(",");
                if (i != -1)
                {
                    text = text.Remove(i);
                }
                text = text.Replace("\"", "").Replace(":", "").Trim();
                return text;
            }
        }
    }

}