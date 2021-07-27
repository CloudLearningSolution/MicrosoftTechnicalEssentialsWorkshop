using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DroneDAL.Models;

namespace DroneDAL.EF
{
    //TODO 6. What is Entity Framework and why utilize DataInitializer class?
    public class DataInitializer : DropCreateDatabaseAlways<DroneDALEntities>
    {
        protected override void Seed(DroneDALEntities context)
        {
            //TODO 9. Define a new System Collection Generic List. Make the List of customer objects, filled with collection object instantiation syntax.
            var customers = new List<Customer>
            {
                new Customer {FirstName = "David", LastName = "Santana"},
                new Customer {FirstName = "Kimberly", LastName = "Watson"},
                new Customer {FirstName = "Wendy", LastName = "Wiessner"},
                new Customer {FirstName = "Rachel", LastName = "MCInerney Mangum"},
                new Customer {FirstName = "Dan", LastName = "Obrian"},
                
            };
            customers.ForEach(x => context.Customers.Add(x));
            var drones = new List<Inventory>
            {
                new Inventory {Make = "Action Drone", Color = "Black", PetName = "Alpha"},
                new Inventory {Make = "Advanced Aircraft", Color = "Rust", PetName = "Bravo"},
                new Inventory {Make = "Aero Systems", Color = "Black", PetName = "Charlie"},
                new Inventory {Make = "Aerovionment", Color = "Yellow", PetName = "Delta"},
                new Inventory {Make = "AgEagle", Color = "Black", PetName = "Echo"},
                new Inventory {Make = "AgrowDrone", Color = "Green", PetName = "Foxtrot"},
                new Inventory {Make = "Airgility", Color = "Pink", PetName = "Golf"},

            };
            drones.ForEach(x => context.Inventory.Add(x));

            var orders = new List<Order>
            {
                new Order {Drone = drones[0], Customer = customers[0]},
                new Order {Drone = drones[1], Customer = customers[1]},
                new Order {Drone = drones[2], Customer = customers[2]},
                new Order {Drone = drones[3], Customer = customers[3]},
                new Order {Drone = drones[4], Customer = customers[4]},
            };
            orders.ForEach(x => context.Orders.Add(x));
            context.SaveChanges();

        }
    }
}
