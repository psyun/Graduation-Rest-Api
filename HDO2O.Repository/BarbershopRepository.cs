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
    public class BarbershopRepository : BaseRepository<Barbershop, HDDbContext>, IBarbershopRepository
    {
        public BarbershopRepository(IDbContextFactory<HDDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
        public override Barbershop Add(Barbershop entity)
        {
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new RepoException(ResponseCodeEnum.INVALID_MODELSTATE, "店铺名称不能为空");
            }
            if (string.IsNullOrEmpty(entity.LocationTitle))
            {
                throw new RepoException(ResponseCodeEnum.INVALID_MODELSTATE, "地理位置不能为空");
            }
            return base.Add(entity);
        }
        public override Barbershop Update(Barbershop entity)
        {
            return base.Update(entity);
        }
    }
}
