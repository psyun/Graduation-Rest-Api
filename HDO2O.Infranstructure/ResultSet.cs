using System.Collections.Generic;

namespace HDO2O.Infranstructure
{
    public class ResultSet<T>
        where T : class
    {
        public PageInfoDto pageInfo { get; set; }
        public IEnumerable<T> data { get; set; }
    }
}
