using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public abstract class BaseRepository<TEntity, TContext> : IDisposable
        where TEntity : class, new()
        where TContext : DbContext
    {
        protected readonly IDbSet<TEntity> _dbSet;
        protected readonly TContext _dbContext;

        public BaseRepository(IDbContextFactory<TContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.GetContext();
            _dbSet = _dbContext.Set<TEntity>();
        }
        public virtual TEntity GetById(Guid id)
        {
            var result = _dbSet.Find(id);
            if (result == null)
            {
                //TODO:throw not found exception
            }
            return result;
        }
        public virtual TEntity GetById(int id)
        {
            var result = _dbSet.Find(id);
            if (result == null)
            {
                //TODO:throw not found exception
            }
            return result;
        }
        public virtual TEntity GetById(string id)
        {
            var result = _dbSet.Find(id);
            if (result == null)
            {
                //TODO:throw not found exception
            }
            return result;
        }
        public TEntity GetFirst(Func<TEntity, bool> predicate)
        {
            var result = _dbSet.Where(predicate).FirstOrDefault();
            if (result == null)
            {
                //TODO:throw not found exception
            }
            return result;
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }
        public virtual IQueryable<TEntity> GetMany(Func<TEntity, bool> predicate)
        {
            var result = _dbSet.Where(predicate);
            return result.AsQueryable();
        }
        public virtual ResultSet<TEntity> GetMany(Func<TEntity, bool> predicate, PagerDto pager)
        {
            var result = new ResultSet<TEntity>();

            result.pageInfo.total = _dbSet.Where(predicate).Count();
            //TODO:how to order data?
            result.data = _dbSet.Where(predicate)
                .Skip(pager.GetSkipCount())
                .Take(pager.pageSize);

            return result;
        }
        public virtual TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }
        public virtual TEntity Update(TEntity entity)
        {
            var result = _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;

            return result;
        }
        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public virtual void Delete(Guid id)
        {
            _dbSet.Remove(this.GetById(id));
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
