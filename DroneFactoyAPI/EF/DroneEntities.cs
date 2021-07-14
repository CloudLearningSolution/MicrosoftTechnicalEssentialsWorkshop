namespace DroneFactoyAPI.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DroneEntities : DbContext
    {
        public DroneEntities()
            : base("name=DroneConnection")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Drone> Drones { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drone>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Drone)
                .WillCascadeOnDelete(false);
        }
    }
}
