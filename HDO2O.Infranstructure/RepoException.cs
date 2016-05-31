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
            this.code = code;
            this.description = description;
        }
        public ResponseCodeEnum code { get; set; }
        public string description { get; set; }
    }
}
