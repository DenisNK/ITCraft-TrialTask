using ITCraft_TrialTask.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Models
{
    public class ItCraftDbContext : DbContext
    {                                              

        public ItCraftDbContext(DbContextOptions<ItCraftDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations());
         
            base.OnModelCreating(modelBuilder);
        }
    }
}
