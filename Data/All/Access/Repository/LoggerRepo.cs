using APIHome.Data.All.Access.EF;
using System;
using System.Linq;

namespace APIHome.Data
{

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