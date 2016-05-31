using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public class DbContextFactory : IDbContextFactory<HDDbContext>
    {
        private HDDbContext _dbContext;
        public HDDbContext GetContext()
        {
            return _dbContext ?? (_dbContext = new HDDbContext());
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
