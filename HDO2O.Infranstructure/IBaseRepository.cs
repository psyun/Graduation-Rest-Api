using System;
using System.Collections.Generic;

namespace HDO2O.Infranstructure
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(Guid id);
        TEntity GetById(string id);
        TEntity GetFirst(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetMany(Func<TEntity, bool> predicate);
        ResultSet<TEntity> GetMany(Func<TEntity, bool> predicate, PagerDto pager);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
    }
}
