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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MembershipCardId")]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int BarbershopId { get; set; }

        public virtual Barbershop Barbershop { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
