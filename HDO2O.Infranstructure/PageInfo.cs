using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    /// <summary>
    /// define the page info of server json data
    /// </summary>
    public class PageInfoDto
    {
        public int total { get; set; }
        public bool hasNext { get; set; }
    }
}
