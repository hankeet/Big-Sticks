using Company.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Commpany.DalFactory
{
   public class DbSessionFactory
    {
        public static IDbSession GetCurrentSession()
        {
            IDbSession db = CallContext.GetData("IDbSession") as IDbSession;
            if (db == null)
            {
                db = new DbSession();
                CallContext.SetData("IDbSession", db);
            }
            return db;
        }
    }
}
