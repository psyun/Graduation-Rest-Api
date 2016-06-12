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
        public string id { get; set; }
        public string nickName { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? birthDay { get; set; }
        public int barbershopId { get; set; }
        public string thumbnailUrl { get; set; }


        public HairDresserDTO() { }

        public HairDresserDTO(HairDresser entity)
            : base(entity)
        {
            this.id = entity.GetId();
            this.birthDay = entity.BirthDay;
            this.nickName = entity.NickName;
            this.sign = entity.Sign;
            this.thumbnailUrl = "http://hair.2liang.net/d/file/hair/liuhai/2013-08/29cbf8adba53e57a748afa3e0cd359de.jpg";
        }


        public override HairDresser ToEntity()
        {
            return new HairDresser
            {
                Sign = this.sign,
                NickName = this.nickName,
                BirthDay = this.birthDay
            };
        }
    }
}
