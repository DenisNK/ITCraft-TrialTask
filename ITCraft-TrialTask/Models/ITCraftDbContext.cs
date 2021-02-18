using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Models
{
    public class ITCraftDbContext : DbContext
    {                                              

        public ITCraftDbContext(DbContextOptions<ITCraftDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users{ get; set; }
    }
}
