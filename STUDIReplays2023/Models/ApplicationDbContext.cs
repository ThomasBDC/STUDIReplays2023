using Microsoft.EntityFrameworkCore;

namespace STUDIReplays2023.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        //Liste des tables de mon contexte
        public DbSet<Replay> Replays { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}
