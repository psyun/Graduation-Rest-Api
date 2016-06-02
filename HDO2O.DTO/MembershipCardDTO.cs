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



        public MembershipCardDTO() { }


        public MembershipCardDTO(MembershipCard entity) :base(entity)
        {
            this.BarbershopId = entity.BarbershopId;
            this.CustomerId = CustomerId;
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
