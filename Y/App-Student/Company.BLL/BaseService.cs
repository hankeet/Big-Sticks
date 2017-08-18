using Commpany.DalFactory;
using Company.IBLL;
using Company.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL
{
       public abstract class BaseService<T>:IBaseService<T> where T : class, new()
    {
        public IBaseDal<T> CurrentDal { get; set; }
        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambada)
        {
            return CurrentDal.Get(whereLambada);
        }

        public IDbSession dbSession
        {
            get
            {
                return DbSessionFactory.GetCurrentSession();
            }
        }
        public BaseService()
        {
            SetCurrentDal();
        }
        public abstract void SetCurrentDal();

        public IQueryable<T> GetPage<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLamba, bool isAsc)
        {
            return CurrentDal.GetPage(pageSize, pageIndex, out total, whereLambda, orderByLamba, isAsc);
        }

        public T Add(T entity)
        {
            dbSession.SaveChanges();
            CurrentDal.Add(entity);
            return entity;

        }
        public bool Update(T entity)
        {

            CurrentDal.Update(entity);
            return dbSession.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return dbSession.SaveChanges() > 0;
        }

    }
}
