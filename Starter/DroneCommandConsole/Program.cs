#region Delete this entire region before reviewing the tasks labeled TODO
using System;


namespace DroneCommandConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Drone Command Console *****\n");


			Console.ReadLine();
		}
	}
}

#endregion

#region Do NOT delete this region. Read the instructions in the comments or ask your instructor for assistance.
/* //Important:Delete the characters located on this line.
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
//TODO 1: Add using statements to reference DroneFactory; DroneFactory.ConnectedLayer; DroneFactory.Models; and a static System.Console;
using placeholder
using placeholder
using placeholder
using placeholder


namespace AutoLotCUIClient
{
	class Program
	{
		//TODO 3: In the main method print the following string Drone Inventory Command Console.
		static void Main(string[] args)
		{
			WriteLine(placeholder);

			//TODO 4: Get connection string from App.config.
			string connectionString =
			  ConfigurationManager.placeholder;
			bool userDone = false;
			string userCommand = "";

			//TODO 5: Create our InventoryDAL object.
			InventoryDAL invDAL = placeholder
			invDAL.OpenConnection(connectionString);

			//TODO 6: Continue this loop, asking for input until user presses the Q key.
			try
			{
				ShowInstructions();
				placeholder
				{
					Write("\nPlease enter your command: ");
					userCommand = ReadLine();
					WriteLine();
					placeholder (userCommand?.ToUpper() ?? "")
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
				}placeholder(!userDone);
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
			/*TODO 7: Develop show instructions method that prints the following:
			 * I: Inserts a new drone.
			 * U: Updates an existing drone.
			 * D: Deletes an existing drone.
			 * L: Lists current inventory.
			 * S: Shows these instructions.
			 * P: Looks up pet name.
			 * Q: Quits program

			*/
/* //Important:Delete the characters located on this line.
 * 
			WriteLine placeholder
			WriteLine placeholder
			WriteLine placeholder
			WriteLine placeholder
			WriteLine placeholder
			WriteLine placeholder
			WriteLine placeholder
		}

		private static void ListInventoryViaList(InventoryDAL invDAL)
		{
			//TODO Final: Get a list of the inventory using Generic Lists.
			placeholder<NewDrone> record = invDAL.GetAllInventoryAsList();

			WriteLine("DroneId:\tMake:\tColor:\tPetName:");
			foreach (NewDrone c in record)
			{
				WriteLine($"{c.DroneId}\t{c.Make}\t{c.Color}\t{c.PetName}");
			}
		}

		//TODO 8: Develop a private method that returns a list of objects from InventoryDaL 
		placeholder (InventoryDAL invDAL)
		{
			// Get the list of inventory.
			DataTable dt = invDAL.GetAllInventoryAsDataTable();
			// Pass DataTable to helper function to display.
			DisplayTable(dt);
		}
		private static void DisplayTable(DataTable dt)
		{
			//TODO 9: Print column names.
			for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
			{
				Write($"\t");
			}
			WriteLine("\n----------------------------------");

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
		placeholder( invDAL)
		{
			//TODO 12: Get ID of drone to delete.
			Write("Enter ID of the drone to delete: ");
			 placeholder id = int.Parse(placeholder() ?? "0");

			// Just in case we have a primary key violation!
			//TODO 13: Develop exception handling
			placeholder
			{
				invDAL.Deletedrone(id);
			}
			placeholder (placeholder ex)
			{
				WriteLine(ex.Message);
			}
		}

		//TODO 14: Develop insertNewDrone method
		placeholder static void placeholder(placeholder invDAL)
		{
			Write("Enter Drone ID: ");
			placeholder newDroneId = int.Parse(placeholder() ?? "0");
			Write("Enter Drone Color: ");
			placeholder newDroneColor = placeholder();
			Write("Enter Drone Make: ");
			placeholder newDroneMake = placeholder();
			Write("Enter Pet Name: ");
			placeholder newDronePetName = placeholder();

			// Now pass to data access library.
			// invDAL.InsertAuto(newDroneId, newDroneColor, newDroneMake, newDronePetName);
			var c = new NewDrone
			{
				DroneId = newDroneId,
				Color = placeholder,
				Make = placeholder,
				PetName = placeholder
			};
			invDAL.InsertAuto(c);
		}

		//TODO 15: Develop a method to update the drone alias
		private static void UpdatedronePetName(InventoryDAL invDAL)
		{
			// First get the user data.
			placeholder("Enter Drone ID: ");
			placeholder droneId = int.Parse(placeholder() ?? "0");
			placeholder("Enter New Pet Name: ");
			placeholder newDronePetName = placeholder();

			// Now pass to data access library.
			placeholder.UpdatedronePetName(droneId, newDronePetName);
		}

		//TODO 16: Develop a method to lookup drones by alias.
		private static placeholder LookUpPetName(InventoryDAL placeholder)
		{
			// Get ID of Drone to look up.
			Write("Enter ID of Drone to look up: ");
			int placeholder = int.Parse(ReadLine() ?? "0");
			WriteLine($"Petname of {placeholder} is {invDAL.placeholder(placeholder).TrimEnd()}.");
		}
		//TODO 17: Debug your code and test your methods

	}
}
  //Important:Remove the characters located on this line. */
#endregion