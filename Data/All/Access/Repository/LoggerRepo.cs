using APIHome.Data.All.Access.EF;
using System;
using System.Linq;

namespace APIHome.Data
{
    /// <summary>
    /// logger that log the given message in the database
    /// </summary>
    public class LoggerRepo : ILoggerRepo
    {

        public void Log(string Message)
        {
            using (APIHomeSitEntities ctx = new APIHomeSitEntities())
            {
                LOGGING log = new LOGGING() { INSERT_DATE = DateTime.Now, MESSAGE = Message };
                ctx.LOGGINGs.Add(log);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// For the given API method, with URL and method name, increase the count and save 
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Name"></param>
        public void LogApiCount(string URL, string Name)
        {
            using (APIHomeSitEntities ctx = new APIHomeSitEntities())
            {
                COUNTER rec = ctx.COUNTERs.FirstOrDefault(ct => ct.URL == URL && ct.CATEGORY == Name);
                if (rec == null)
                {
                    rec = new COUNTER();
                    rec.URL = URL;
                    rec.CATEGORY = Name;
                    ctx.COUNTERs.Add(rec);
                }
                rec.VALUE = (rec.VALUE ?? 0) + 1;
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// For the given API method, with URL and method name, get the count 
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public int GetApiCount(string URL, string Name)
        {
            using (APIHomeSitEntities ctx = new APIHomeSitEntities())
            {
                var rec = ctx.COUNTERs.FirstOrDefault(ct => ct.URL == URL && ct.CATEGORY == Name);
                return rec == null ? 0 : rec.VALUE ?? 0;
            }
        }

    }
}