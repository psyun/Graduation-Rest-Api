﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HDO2O.Infranstructure
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(Guid id);
        TEntity GetById(string id);
        TEntity GetById(int id);
        TEntity GetFirst(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetMany(Func<TEntity, bool> predicate);
        PageResponseResult<TEntity> GetMany(Func<TEntity, bool> predicate, PagerDto pager);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
    }
}
