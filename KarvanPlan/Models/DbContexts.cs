using Microsoft.EntityFrameworkCore;

namespace KarvanPlan.Models
{
    public class DbContexts : DbContext
    {
        public DbContexts(DbContextOptions<DbContexts> options) : base(options)
        {
        }

        public DbSet<PlanEntities> PlanEntities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<PlanEntities>().HasNoKey().ToFunction("IB_Plans");
        }
       
     

    }
}

