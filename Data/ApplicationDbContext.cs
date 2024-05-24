using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Airbnbanalyzer.Models;

namespace Airbnbanalyzer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Airbnbanalyzer.Models.Listing> Listing { get; set; } = default!;
    }
}
