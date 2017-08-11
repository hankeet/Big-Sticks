using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App_Student.IRepository
{
   public interface InterfaceBaseRepository<T>
    {
        T Add(T entity);

        int Count(Expression<Func<T, bool>> predicate);

        bool Delete(T entity);

        bool Update(T entity);

        bool Exist(Expression<Func<T,bool>> whereLambda);

        IQueryable<T> FindList<T>(Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T,string>> orderLamdba);

        IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba);
    }
}
