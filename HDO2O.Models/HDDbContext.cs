using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HDO2O.Models
{
    public class HDDbContext : IdentityDbContext<HairDresser>
    {
        public HDDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static HDDbContext Create()
        {
            return new HDDbContext();
        }

        public IDbSet<Barbershop> Barbershops { get; set; }
        public IDbSet<BarbershopHairDresser> BarbershopHairDressers { get; set; }
        public IDbSet<Follower> Followers { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<MembershipCard> MembershipCard { get; set; }
        public IDbSet<HairDressLibrary> HairDressLibraries { get; set; }
        public IDbSet<MyHairDressLibrary> MyHairDressLibraries { get; set; }
    }
}
