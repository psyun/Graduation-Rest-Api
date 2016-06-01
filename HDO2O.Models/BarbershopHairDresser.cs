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
        /// <summary>
        /// 理发师类型
        /// 1 普通理发师
        /// 2 理发店Owner
        /// </summary>
        public int Type { get; set; }

        public virtual Barbershop Barbershop { get; set; }
        public virtual HairDresser HairDresser { get; set; }
    }
}
