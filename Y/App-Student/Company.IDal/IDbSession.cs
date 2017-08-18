using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.IDal
{
   public interface IDbSession
    {
        int SaveChanges();
      //  IUserDao UserDao { get; }
    }
}
