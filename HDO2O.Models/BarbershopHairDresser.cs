using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Models
{
    /// <summary>
    /// 理发店里的理发师
    /// </summary>
    public class BarbershopHairDresser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BarbershopHairDresserId")]
        public int Id { get; set; }
        public int BarbershopId { get; set; }
        public string HairDresserId { get; set; }
        public BarbershopHairDresserType Type { get; set; }
        public BarbershopHairDresserVerifyState VerifyState { get; set; }

        public virtual Barbershop Barbershop { get; set; }
        public virtual HairDresser HairDresser { get; set; }
    }

    public enum BarbershopHairDresserVerifyState
    {
        /// <summary>
        /// 审核通过
        /// </summary>
        Pass = 1,
        /// <summary>
        /// 审核不通过
        /// </summary>
        UnPass = 2,
        /// <summary>
        /// 未审核状态
        /// </summary>
        UnVerify = 3
    }
    public enum BarbershopHairDresserType
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        General = 1,
        /// <summary>
        /// 理发店Owner
        /// </summary>
        Owner = 2
    }
}
