using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneFactoyAPI.EF;

using static System.Console;
namespace DroneFactoyAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("***** Current Drone Inventory *****\n");
            //PrintAllInventory();
            //ReadLine();
        }
        #region
        private static int AddNewRecord()
        {
            // Add record to the inventory table of the drone database
            using (var context = new DroneEntities())
            {
                try
                {
                    // create a new record for testing.
                    var drone = new Drone() { Make = "Parrot", Color = "Army Green", DroneNickName = "Ranger" };
                    context.Drones.Add(drone);
                    context.SaveChanges();
                    // EF automatically populates the identity field.
                    return drone.DroneId;
                }
                catch(Exception ex)
                {
                    WriteLine(ex.InnerException.Message);
                    return 0;
                }
            }
        }
        #endregion
        public static void PrintAllInventory()
        {
            using (var context = new DroneEntities())
            {
                foreach (Drone d in context.Drones)
                {
                    WriteLine(d);
                }
            }
        }
    }
}
