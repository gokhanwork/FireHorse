using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.EfCodeFirstMappings;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class FireHorseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QCVLLUQ\SQL2019;Database=FireHorse;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TableMap());
        }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Table> Tables { get; set; }

        /// <summary>
        /// Save Changes eziyoruz
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
   
            return base.SaveChanges();
        }

    }
}
