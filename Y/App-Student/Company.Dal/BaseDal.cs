using Company.EFModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Company.Dal
{
  public  class BaseDal<T> where T : class, new()
    {
        public Y_JobEntities yc = (Y_JobEntities)DbContextFactory.GetCurrentDbContext();


        public IQueryable<T> Get(Expression<Func<T, bool>> wherelambada)
        {
            return yc.Set<T>().Where(wherelambada).AsQueryable();//遍历集合，把每个值传到委托里面去，最后把满足条件的元素返回
        }
        public IQueryable<T> GetPage<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambada, Expression<Func<T, S>> orderByLamabada, bool isAsc)
        {
            total = yc.Set<T>().Where(whereLambada).Count();
            if (isAsc)
            {
                var temp = yc.Set<T>().Where(whereLambada).OrderBy<T, S>(orderByLamabada).Skip(pageSize * (pageIndex - 1)).Take(pageSize).AsQueryable();
                return temp;
            }
            else
            {
                var temp = yc.Set<T>().Where(whereLambada).OrderByDescending<T, S>(orderByLamabada).Skip(pageSize * (pageIndex - 1)).Take(pageSize).AsQueryable();
                return temp;
            }
        }
        public T Add(T entity)
        {
            yc.Set<T>().Add(entity);
            yc.SaveChanges();
            return entity;
        }
        public bool Update(T entity)
        {
            yc.Entry(entity).State = EntityState.Modified;
            return true;
        }
        public bool Delete(T entity)
        {
            yc.Entry(entity).State = EntityState.Deleted;
            return true;
        }
    }
}
