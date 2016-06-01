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
    /// 发型师的发型库，可以是自己上传的，也可以是从别人那里复制的
    /// </summary>
    public class MyHairDressLibrary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MyHairDressLibraryId")]
        public int Id { get; set; }
        public string HairDresserId { get; set; }
        public int HairDressLibraryId { get; set; }
        /// <summary>
        /// 所属类型
        /// 1 该发型师是该发型的创建人
        /// 2 该发型师是从别人那里复制的该发型
        /// </summary>
        public int ForkType { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual HairDresser HairDresser { get; set; }
        public virtual HairDressLibrary HairDressLibrary { get; set; }
    }
}
