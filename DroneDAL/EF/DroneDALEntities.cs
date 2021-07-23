namespace DroneDAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DroneDAL.Models;
    //TODO 7. <place holder for case study workshop 2; learners research the DbContext, and DbSet class>
    public class DroneDALEntities : DbContext
    {
        // Your context has been configured to use a 'DroneDALEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DroneDAL.EF.DroneDALEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DroneDALEntities' 
        // connection string in the application configuration file.
        public DroneDALEntities()
            : base("name=DroneDALConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 

        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}