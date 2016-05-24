using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    /// <summary>
    /// receive the method of paging and filter from client
    /// </summary>
    public class PagerDto
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public Nullable<int> skip { get; set; }
        /// <summary>
        /// determine how to order the json data
        /// request example:
        /// userId desc
        /// userId asc
        /// </summary>
        public string orderBy { get; set; }

        public int GetSkipCount()
        {
            if (skip.HasValue)
            {
                return this.skip.Value;
            }
            else
            {
                return (this.page - 1) * this.pageSize;
            }
        }
    }
}
