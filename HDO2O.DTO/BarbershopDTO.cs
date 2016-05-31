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
        public string BusinessLicense { get; set; }
        public Guid Id { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string LocationTitle { get; set; }
        public string Name { get; set; }

        public BarbershopDTO(Barbershop entity)
            : base(entity)
        {
            this.BusinessLicense = entity.BusinessLicense;
            this.Id = entity.Id;
            this.Lat = entity.Lat;
            this.Lng = entity.Lng;
            this.LocationTitle = entity.LocationTitle;
            this.Name = entity.Name;
        }
        public override Barbershop ToEntity()
        {
            return new Barbershop
            {
                Id = this.Id,
                BusinessLicense = this.BusinessLicense,
                Lat = this.Lat,
                Lng = this.Lng,
                LocationTitle = this.LocationTitle,
                Name = this.Name
            };
        }
    }
}
