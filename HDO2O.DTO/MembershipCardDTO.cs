using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class MembershipCardDTO : BaseDTO<MembershipCard>
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int BarbershopId { get; set; }
        public string CustomerName { get; set; }
                public string BarbershopName { get; set; }

        public string BarbershopLocationTitle { get; set; }

        public string CustomerSign { get; set; }

        public MembershipCardDTO() { }


        public MembershipCardDTO(MembershipCard entity)
            : base(entity)
        {
            this.BarbershopId = entity.BarbershopId;
            this.CustomerId = entity.CustomerId;
            this.BarbershopName = entity.Barbershop.Name;
            this.BarbershopLocationTitle = entity.Barbershop.LocationTitle;
            this.CustomerName = entity.Customer.NickName;
            this.CustomerSign = entity.Customer.Sign;
            this.Id = entity.Id;
        }

        public override MembershipCard ToEntity()
        {
            return new MembershipCard
            {
                Id = this.Id,
                BarbershopId = this.BarbershopId,
                CustomerId = this.CustomerId
                
            };
        }
    }
}
