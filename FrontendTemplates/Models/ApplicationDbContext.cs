using Microsoft.AspNet.Identity.EntityFramework;

namespace FrontendTemplates.Models
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

        public System.Data.Entity.DbSet<FrontendTemplates.Models.Product> Products { get; set; }
    }
}