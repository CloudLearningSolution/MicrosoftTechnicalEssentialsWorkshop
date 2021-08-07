//SOLUTIONFILE
//TODO 0: Please review the contents of the SOLUTIONFILE.cs.\n
//Use the Tasklist feature located in the visual studio view tab to navigate the recommended tasks.
//....... Important: This files task list corresponds with the Program.cs task list.
//....... Important: Inform the students to replace the instructor defined training TEXT labeled 'placeholder'\n
//within the TODO tasks with thier own code.
//....... Instructor notes: DO NOT PROVIDE THIS FILE TO STUDENTS.
//....... Instructors are recommended to assist students through the case study workshop activity tasks\n
//but the students must be allowed several attempts before receiving assistance.
#region Below you will find the SOLUTIONFILE.cs code which has been commented out
/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
//TODO 1: Add using statements to reference DroneFactory; DroneFactory.ConnectedLayer; DroneFactory.Models; and a static System.Console;
using DroneFactory;
using DroneFactory.ConnectedLayer;
using DroneFactory.Models;
using static System.Console;

namespace AutoLotCUIClient //TODO Tuesday: develop SOLUTIONFILE.cs derived from current Program.cs
{
	class Program
	{
		//TODO 3: In the main method print the following string Drone Inventory Command Console.
		static void Main(string[] args)
		{
			WriteLine("***** Drone Inventory Command Console *****\n");

			// Get connection string from App.config.
			//TODO 4: Get connection string from App.config.
			string connectionString =
			  ConfigurationManager.ConnectionStrings["DroneDALConnection"].ConnectionString;
			bool userDone = false;
			string userCommand = "";

			// Create our InventoryDAL object.
			//TODO 5: Create our InventoryDAL object.
			InventoryDAL invDAL = new InventoryDAL();
			invDAL.OpenConnection(connectionString);

			// Keep asking for input until user presses the Q key.
			//TODO 6: Continue this loop, asking for input until user presses the Q key.
			try
			{
				ShowInstructions();
			//TODO 7: Develop show instructions method that prints the following:
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
			//TODO Final: Get a list of the inventory using Generic Lists.
			List<NewDrone> record = invDAL.GetAllInventoryAsList();

			WriteLine("DroneId:\tMake:\tColor:\tPetName:");
			foreach (NewDrone c in record)
			{
				WriteLine($"{c.DroneId}\t{c.Make}\t{c.Color}\t{c.PetName}");
			}
		}

		//TODO 8: Develop a private method that returns a list of objects from InventoryDaL 
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
			//TODO 9: Print column names.
			for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
			{
				Write($"{dt.Columns[curCol].ColumnName}\t");
			}
			WriteLine("\n----------------------------------");

			// Print the DataTable.
			//TODO 10: Print data table.
			for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
			{
				for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
				{
					Write($"{dt.Rows[curRow][curCol]}\t");
				}
				WriteLine();
			}
		}

		//TODO 11: Develop a method named Deletedrone using InventoryDAL.
		private static void Deletedrone(InventoryDAL invDAL)
		{
			// Get ID of drone to delete.
			//TODO 12: Get ID of drone to delete.
			Write("Enter ID of the drone to delete: ");
			int id = int.Parse(ReadLine() ?? "0");

			// Just in case we have a primary key violation!
			//TODO 13: Develop exception handling
			try
			{
				invDAL.Deletedrone(id);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}
		//TODO 14: Develop insertNewDrone method
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
		//TODO 15: Develop a method to update the drone alias
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

		//TODO 16: Develop a method to lookup drones by alias.
		private static void LookUpPetName(InventoryDAL invDAL)
		{
			// Get ID of Drone to look up.
			Write("Enter ID of Drone to look up: ");
			int id = int.Parse(ReadLine() ?? "0");
			WriteLine($"Petname of {id} is {invDAL.LookUpPetName(id).TrimEnd()}.");
		}

	}
}
		//TODO 17: Debug your code and test your methods



*/
#endregion