using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace randburg_methodist_church_DAL
{
    public class RandburgChurchDAL : DbContext
    {
        public DbSet<RandMethAdmin> RandMethAdmins { get; set; }

        public RandburgChurchDAL(DbContextOptions<RandburgChurchDAL> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultContainer("RandMethAdmin");
            //modelBuilder.Entity<RandMethAdmin>().ToContainer("Users").HasPartitionKey(u => u.Username);
        }
    }
}
