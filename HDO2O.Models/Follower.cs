using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Models
{
    public class Follower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FollowerId")]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string HairDresserId { get; set; }

        public virtual HairDresser HairDresser { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
