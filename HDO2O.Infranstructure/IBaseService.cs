using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public interface IBaseService<TDTO>
        where TDTO : class
    {
        ResponseResult GetById(Guid id);
        ResponseResult GetById(string id);
        ResponseResult GetById(int id);
        ResponseResult GetAll();
        ResponseResult Add(TDTO dto);
        ResponseResult Update(TDTO dto);
        ResponseResult Delete(int id);
        ResponseResult Delete(string id);
        int Commit();
    }
}
