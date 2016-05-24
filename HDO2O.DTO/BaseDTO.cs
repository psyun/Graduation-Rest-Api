using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseDTO<TEntity>
        where TEntity : class, new()
    {
        public BaseDTO()
        {

        }
        public BaseDTO(TEntity entity)
        {

        }

        public virtual TEntity ToEntity()
        {
            throw new NotImplementedException();
        }
    }
}
