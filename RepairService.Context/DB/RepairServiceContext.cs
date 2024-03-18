using RepairService.Context.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.DB
{
    public class RepairServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<BrokenType> BrokenTypes { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentType> EquipmentTypes { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<SparesCount> SparesCounts { get; set; }

        public DbSet<SparesType> SparesTypes { get; set; }

        public RepairServiceContext():base("DefCon")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany(x => x.OrderClient)
                .WithRequired(x => x.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
               .HasMany(x => x.OrderWorkers)
               .WithMany(x => x.Workers);
        }

    }
}
