using Microsoft.EntityFrameworkCore;

namespace STUDIReplays2023.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
           : base(options)
        {
        }

        //Liste des tables de mon contexte
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<Replay> Replays { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}
