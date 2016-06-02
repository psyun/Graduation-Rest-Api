using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class FollowerDTO:BaseDTO<Follower>
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string HairDresserId { get; set; }

        public FollowerDTO() { }
        public FollowerDTO(Follower entity):base(entity)
        {
            this.CustomerId = entity.CustomerId;
            this.HairDresserId = entity.HairDresserId;
            this.Id = entity.Id;
        }

        public override Follower ToEntity()
        {
            return new Follower
            {
                Id = this.Id,
                HairDresserId = this.HairDresserId,
                CustomerId = this.CustomerId
            };
        }
    }
}
