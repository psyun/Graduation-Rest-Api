using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Models
{
    public class HairDressLibrary
    {
        [Key]
        [Column("HairDressLibraryId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbnailImage { get; set; }
        /// <summary>
        /// 发型的介绍图，有左侧面、正面、右侧面、后面四个图组成，使用,进行分割
        /// </summary>
        public string Image { get; set; }


        public virtual ICollection<MyHairDressLibrary> MyHairDressLibraries { get; set; }
    }
}
