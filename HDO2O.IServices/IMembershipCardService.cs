using HDO2O.DTO;
using HDO2O.Infranstructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.IServices
{
    public interface IMembershipCardService : IBaseService<MembershipCardDTO>
    {
        ResponseResult GetMany(int barbershopId);
    }
}
