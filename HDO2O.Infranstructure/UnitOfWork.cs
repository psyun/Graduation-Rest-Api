using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private HDDbContext _dbContext;
        private readonly IDbContextFactory<HDDbContext> _dbContextFactory;
        protected HDDbContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _dbContextFactory.GetContext());
            }
        }
        public UnitOfWork(IDbContextFactory<HDDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public int Commit()
        {
            return DbContext.SaveChanges();
        }
    }
}
