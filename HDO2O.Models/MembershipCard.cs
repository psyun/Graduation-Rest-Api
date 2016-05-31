using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Models
{
    public class MembershipCard
    {
        [Key]
        [Column("MembershipCardId")]
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public Guid BarbershopId { get; set; }

        public virtual Barbershop Barbershop { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
