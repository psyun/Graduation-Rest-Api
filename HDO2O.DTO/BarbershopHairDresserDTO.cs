using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class BarbershopHairDresserDTO:BaseDTO<BarbershopHairDresser>
    {
        public int Id { get; set; }
        public int BarbershopId { get; set; }
        public string HairDresserId { get; set; }
        /// <summary>
        /// 理发师类型
        /// 1 普通理发师
        /// 2 理发店Owner
        /// </summary>
        public int Type { get; set; }




        public BarbershopHairDresserDTO() { }


        public BarbershopHairDresserDTO(BarbershopHairDresser entity) : base(entity) 
        {
            this.Id = entity.Id;
            this.BarbershopId = entity.BarbershopId;
            this.HairDresserId = entity.HairDresserId;
            this.Type = entity.Type;
        }

        public override BarbershopHairDresser ToEntity()
        {
            return new BarbershopHairDresser
            {
                Id = this.Id,
                Type = this.Type,
                HairDresserId = this.HairDresserId,
                BarbershopId = this.BarbershopId
            };
        }
    }
}
