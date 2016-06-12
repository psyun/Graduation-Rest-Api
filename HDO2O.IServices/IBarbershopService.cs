using HDO2O.DTO;
using HDO2O.Infranstructure;
using HDO2O.Utils;

namespace HDO2O.IServices
{
    public interface IBarbershopService : IBaseService<BarbershopDTO>
    {
        ResponseResult GetNearby(LocationModel location, string keywords);
    }
}
