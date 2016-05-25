using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HDO2O.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public DbSet<Test> Tests { get; set; }
    }
}
