using HDO2O.Infranstructure;
using HDO2O.IRepository;
using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Repository
{
    public class BarbershopHairDresserRepository
        : BaseRepository<BarbershopHairDresser, HDDbContext>, IBarbershopHairDresserRespository
    {
        public BarbershopHairDresserRepository(IDbContextFactory<HDDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
