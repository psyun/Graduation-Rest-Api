using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public class RepoException : Exception
    {
        public RepoException(ResponseCodeEnum code, string description)
        {
            this.ResponseResult = new ResponseResult(code, description);
        }
        public RepoException(ResponseCodeEnum code, string description, object data)
        {
            this.ResponseResult.data = data;
        }
        public ResponseResult ResponseResult { get; private set; }
    }
}
