
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using AutoLotDAL.ConnectedLayer;
using static System.Console;

namespace AdoNetTransaction
{
	class Program
	{
	static void Main(string[] args)
	{
		WriteLine("***** Simple Transaction Example *****\n");
			// Exception Handling.
			bool throwEx = true;

			Write("Do you want to throw an exception (Y or N): ");
			var userAnswer = ReadLine();
			if (userAnswer?.ToLower() == "n")
			{
				throwEx = false;
			}
			// Please update 
			var dal = new InventoryDAL();
			dal.OpenConnection(@"Data Source=(local)\<Place holder for YOUR current systems SQL Database Server Name>;Integrated Security=SSPI;" +
				"Initial Catalog=AutoLot");

			// Transaction.
			dal.ProcessCreditRisk(throwEx, 5);
			WriteLine("Check CreditRisk table for results");

			ReadLine();
	}
}
}
