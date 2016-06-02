using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class MyHairDressLibraryDTO:BaseDTO<MyHairDressLibrary>
    {
        public int Id { get; set; }
        public string HairDresserId { get; set; }
        public int HairDressLibraryId { get; set; }
        public int ForkType { get; set; }
        public DateTime CreateDate { get; set; }



        public MyHairDressLibraryDTO() { }



        public MyHairDressLibraryDTO(MyHairDressLibrary entity) : base(entity) 
        {
            this.Id = entity.Id;
            this.HairDresserId = entity.HairDresserId;
            this.HairDressLibraryId = entity.HairDressLibraryId;
            this.ForkType = entity.ForkType;
            this.CreateDate = entity.CreateDate;
        }


        public override MyHairDressLibrary ToEntity()
        {
            return new MyHairDressLibrary
            {
                CreateDate = this.CreateDate,
                ForkType = this.ForkType,
                HairDresserId = this.HairDresserId,
                HairDressLibraryId = this.HairDressLibraryId,
                Id = this.Id
            };
        }
    }
}
