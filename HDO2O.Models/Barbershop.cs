using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HDO2O.Models
{
    public class Barbershop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BarbershopId")]
        public int Id { get; set; }
        /// <summary>
        /// 理发店名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public double Lat { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double Lng { get; set; }
        /// <summary>
        /// 地理位置标题
        /// </summary>
        public string LocationTitle { get; set; }
        /// <summary>
        /// 营业执照
        /// </summary>
        public string BusinessLicense { get; set; }
        /// <summary>
        /// 序列号,系统随机生成
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// 理发店下的理发师
        /// </summary>
        public virtual ICollection<BarbershopHairDresser> HairDressers { get; set; }
        public virtual ICollection<MembershipCard> MembershipCards { get; set; }
    }
}
