using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public class DbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        private ApplicationDbContext _dbContext;
        public ApplicationDbContext GetContext()
        {
            return _dbContext ?? (_dbContext = new ApplicationDbContext());
        }
        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
