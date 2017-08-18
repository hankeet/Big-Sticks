using Company.Dal;
using Company.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commpany.DalFactory
{
   public class DbSession : IDbSession
    {
        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
        //public IUserDao UserDao
        //{
        //    get { return new UserDao(); }
        //}
    }
}
