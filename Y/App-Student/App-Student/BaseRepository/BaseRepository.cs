using App_Student.IRepository;
using System;
using System.Linq;
using System.Linq.Expressions;
using App_Student.Concrete;

namespace App_Student.BaseRepository
{
    public class BaseRepository<T> : InterfaceBaseRepository<T> where T : class
    {
        protected UserDbContext nContext = new UserDbContext(ContextFactory.GetCurrentContext());
        public T Add(T entity)
        {
            nContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Added;
            nContext.SaveChanges();
            return entity;
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<T, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T1> FindList<T1>(Expression<Func<T1, bool>> whereLambda, bool isAsc, Expression<Func<T1, string>> orderLamdba)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}