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
        private ApplicationDbContext _dbContext;
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        protected ApplicationDbContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _dbContextFactory.GetContext());
            }
        }
        public UnitOfWork(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public int Commit()
        {
            return DbContext.SaveChanges();
        }
    }
}
