using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using DroneFactory;
using DroneFactory.ConnectedLayer;
using DroneFactory.Models;
using static System.Console;

namespace AutoLotCUIClient
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("***** The AutoLot Console UI *****\n");

			// Get connection string from App.config.
			string connectionString =
			  ConfigurationManager.ConnectionStrings["DroneDALConnection"].ConnectionString;
			bool userDone = false;
			string userCommand = "";

			// Create our InventoryDAL object.
			InventoryDAL invDAL = new InventoryDAL();
			invDAL.OpenConnection(connectionString);

			// Keep asking for input until user presses the Q key.
			try
			{
				ShowInstructions();
				do
				{
					Write("\nPlease enter your command: ");
					userCommand = ReadLine();
					WriteLine();
					switch (userCommand?.ToUpper() ?? "")
					{
						case "I":
							InsertNewDrone(invDAL);
							break;
						case "U":
							UpdatedronePetName(invDAL);
							break;
						case "D":
							Deletedrone(invDAL);
							break;
						case "L":
							// ListInventory(invDAL);
							ListInventoryViaList(invDAL);
							break;
						case "S":
							ShowInstructions();
							break;
						case "P":
							LookUpPetName(invDAL);
							break;
						case "Q":
							userDone = true;
							break;
						default:
							WriteLine("wrong!  Try again");
							break;
					}
				} while (!userDone);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
			finally
			{
				invDAL.CloseConnection();
			}
		}
		private static void ShowInstructions()
		{
			WriteLine("I: Inserts a new drone.");
			WriteLine("U: Updates an existing drone.");
			WriteLine("D: Deletes an existing drone.");
			WriteLine("L: Lists current inventory.");
			WriteLine("S: Shows these instructions.");
			WriteLine("P: Looks up pet name.");
			WriteLine("Q: Quits program.");
		}

		private static void ListInventoryViaList(InventoryDAL invDAL)
		{
			// Get the list of inventory.
			List<NewDrone> record = invDAL.GetAllInventoryAsList();

			WriteLine("DroneId:\tMake:\tColor:\tPetName:");
			foreach (NewDrone c in record)
			{
				WriteLine($"{c.DroneId}\t{c.Make}\t{c.Color}\t{c.PetName}");
			}
		}

		private static void ListInventory(InventoryDAL invDAL)
		{
			// Get the list of inventory.
			DataTable dt = invDAL.GetAllInventoryAsDataTable();
			// Pass DataTable to helper function to display.
			DisplayTable(dt);
		}
		private static void DisplayTable(DataTable dt)
		{
			// Print out the column names.
			for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
			{
				Write($"{dt.Columns[curCol].ColumnName}\t");
			}
			WriteLine("\n----------------------------------");

			// Print the DataTable.
			for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
			{
				for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
				{
					Write($"{dt.Rows[curRow][curCol]}\t");
				}
				WriteLine();
			}
		}
		private static void Deletedrone(InventoryDAL invDAL)
		{
			// Get ID of drone to delete.
			Write("Enter ID of the drone to delete: ");
			int id = int.Parse(ReadLine() ?? "0");

			// Just in case we have a primary key violation!
			try
			{
				invDAL.Deletedrone(id);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}
		private static void InsertNewDrone(InventoryDAL invDAL)
		{
			Write("Enter Drone ID: ");
			var newDroneId = int.Parse(ReadLine() ?? "0");
			Write("Enter Drone Color: ");
			var newDroneColor = ReadLine();
			Write("Enter Drone Make: ");
			var newDroneMake = ReadLine();
			Write("Enter Pet Name: ");
			var newDronePetName = ReadLine();

			// Now pass to data access library.
			// invDAL.InsertAuto(newDroneId, newDroneColor, newDroneMake, newDronePetName);
			var c = new NewDrone
			{
				DroneId = newDroneId,
				Color = newDroneColor,
				Make = newDroneMake,
				PetName = newDronePetName
			};
			invDAL.InsertAuto(c);
		}
		private static void UpdatedronePetName(InventoryDAL invDAL)
		{
			// First get the user data.
			Write("Enter Drone ID: ");
			var droneId = int.Parse(ReadLine() ?? "0");
			Write("Enter New Pet Name: ");
			var newDronePetName = ReadLine();

			// Now pass to data access library.
			invDAL.UpdatedronePetName(droneId, newDronePetName);
		}
		private static void LookUpPetName(InventoryDAL invDAL)
		{
			// Get ID of Drone to look up.
			Write("Enter ID of Drone to look up: ");
			int id = int.Parse(ReadLine() ?? "0");
			WriteLine($"Petname of {id} is {invDAL.LookUpPetName(id).TrimEnd()}.");
		}

	}
}
