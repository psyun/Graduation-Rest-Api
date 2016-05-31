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
        TDTO GetById(Guid id);
        IEnumerable<TDTO> GetAll();
        TDTO Add(TDTO dto);
        TDTO Update(TDTO dto);
        int Delete(Guid id);
        int Commit();
    }
}
