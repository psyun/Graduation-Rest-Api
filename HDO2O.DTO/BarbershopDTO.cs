using HDO2O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.DTO
{
    public class BarbershopDTO : BaseDTO<Barbershop>
    {
        public string businessLicense { get; set; }
        public int id { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string locationTitle { get; set; }
        public string name { get; set; }
        public string ownerHairDresserId { get; set; }
        public int hairDresserCount { get; set; }
        public string thumbnailUrl { get; set; }
        public double price { get; set; }

        public BarbershopDTO()
        {

        }
        public BarbershopDTO(Barbershop entity)
            : base(entity)
        {
            this.businessLicense = entity.BusinessLicense;
            this.id = entity.Id;
            this.lat = entity.Lat;
            this.lng = entity.Lng;
            this.locationTitle = entity.LocationTitle;
            this.name = entity.Name;
            this.hairDresserCount = entity.HairDressers.Count;
            this.thumbnailUrl = "http://hair.2liang.net/d/file/hair/liuhai/2013-08/29cbf8adba53e57a748afa3e0cd359de.jpg";
        }
        public override Barbershop ToEntity()
        {
            return new Barbershop
            {
                Id = this.id,
                BusinessLicense = this.businessLicense,
                Lat = this.lat,
                Lng = this.lng,
                LocationTitle = this.locationTitle,
                Name = this.name
            };
        }
    }
}
