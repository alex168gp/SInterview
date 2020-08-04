using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SInterview.DataAccessLayer
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void DeleteById(int id);

        void DeleteByEntity(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
