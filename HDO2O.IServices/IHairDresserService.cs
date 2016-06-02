using HDO2O.DTO;
using HDO2O.Infranstructure;
using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.IServices
{
    public interface IHairDresserService : IBaseService<HairDresserDTO>
    {
        ResponseResult GetHairDresserByBarbershopId(int barbershopId);

        ResponseResult ApplyToJoin(int barbershopId,string userId);

        ResponseResult UpdateHairDressState(int settled, BarbershopHairDresserVerifyState status);

    }
}
