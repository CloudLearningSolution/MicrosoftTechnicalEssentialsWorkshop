using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneDAL;
using DroneDAL.EF;
using DroneDAL.Repos;
using DroneDAL.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using static System.Console;


namespace DroneTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DataInitializer());
            WriteLine("***** Drone Inventory DesktopApp *****\n");
            PrintAllInventory();
            ReadLine();
        }

        private static void PrintAllInventory()
        {
            using (var repo = new InventoryRepo())
            {
                foreach (Inventory c in repo.GetAll())
                {
                    WriteLine(c);
                }
            }
        }
    }
}
