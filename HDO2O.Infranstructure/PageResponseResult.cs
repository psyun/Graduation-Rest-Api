using System.Collections.Generic;

namespace HDO2O.Infranstructure
{
    public class PageResponseResult<T> : ResponseResult
        where T : class
    {
        public PageInfoDto pageInfo { get; set; }
        public new IEnumerable<T> data { get; set; }
    }
}
