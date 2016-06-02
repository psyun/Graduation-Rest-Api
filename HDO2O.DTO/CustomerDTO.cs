using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class CustomerDTO : BaseDTO<Customer>
    {
        public string NickName { get; set; }
        public string Sign { get; set; }
        public DateTime? BirthDay { get; set; }


        public CustomerDTO() { }

        public CustomerDTO(Customer entity)
            : base(entity)
        {
            this.NickName = entity.NickName;
            this.BirthDay = entity.BirthDay;
            this.Sign = entity.Sign;
        }
        public override Customer ToEntity()
        {
            return new Customer
            {
                NickName = this.NickName,
                BirthDay = this.BirthDay,
                Sign = this.Sign
            };
        }
    }
}
