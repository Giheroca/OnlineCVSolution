namespace OnlineCV.Data
{
    using Microsoft.EntityFrameworkCore;
    using OnlineCV.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactRequest> ContactRequests { get; set; } 
    }
}
