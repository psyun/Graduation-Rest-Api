using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class HairDresserDTO : BaseDTO<HairDresser>
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? BirthDay { get; set; }
        public int BarbershopId { get; set; }


        public HairDresserDTO() { }

        public HairDresserDTO(HairDresser entity)
            : base(entity)
        {
            this.Id = entity.GetId();
            this.BirthDay = entity.BirthDay;
            this.NickName = entity.NickName;
            this.Sign = entity.Sign;
        }


        public override HairDresser ToEntity()
        {
            return new HairDresser
            {
                Sign = this.Sign,
                NickName = this.NickName,
                BirthDay = this.BirthDay
            };
        }
    }
}
