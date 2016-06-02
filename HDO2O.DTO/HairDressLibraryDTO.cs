using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class HairDressLibraryDTO : BaseDTO<HairDressLibrary>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbnailImage { get; set; }
        /// <summary>
        /// 发型的介绍图，有左侧面、正面、右侧面、后面四个图组成，使用,进行分割
        /// </summary>
        public string Image { get; set; }



        public HairDressLibraryDTO() { }


        public HairDressLibraryDTO(HairDressLibrary entity) : base(entity) 
        {
            this.Description = entity.Description;
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.ThumbnailImage = entity.ThumbnailImage;
            this.Image = entity.Image;
        }


        public override HairDressLibrary ToEntity()
        {
            return new HairDressLibrary
            {
                Description = this.Description,
                Id = this.Id,
                Image = this.Image,
                ThumbnailImage = this.ThumbnailImage,
                Name = this.Name
            };
        }
    }
}
