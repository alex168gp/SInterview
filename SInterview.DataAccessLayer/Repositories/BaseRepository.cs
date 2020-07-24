using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SInterview.DataAccessLayer
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> mEntities { get; set; }

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context"></param>
		public BaseRepository(SInterviewDbContext context)
        {
            this.mEntities = context.Set<TEntity>();
        }

        #endregion

        #region Public Methods

        public TEntity GetById(int id)
        {
            return mEntities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return mEntities;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return mEntities.Where(predicate);
        }

        public void Add(TEntity entity)
        {
            mEntities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            mEntities.AddRange(entities);
        }

        public void DeleteByEntity(TEntity entity)
        {
            mEntities.Remove(entity);
        }

        public void DeleteById(int id)
        {
            TEntity entity = mEntities.Find(id);
            if (entity != null)
                mEntities.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            mEntities.RemoveRange(entities);
        }

        #endregion
    }
}
