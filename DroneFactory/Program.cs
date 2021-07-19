using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO Install 3rd party Unit testing tool
namespace DroneFactory
{
    #region
    //Beginning Region
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Drone Factory*****\n");
            // Retrieve connection string provider
            string dataProvider =
                ConfigurationManager.AppSettings["provider"];
            string connectionString =
                ConfigurationManager.ConnectionStrings["DroneSqlProvider"].ConnectionString;

            // Retrieve data provider
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            // Subsequently retrieve connection object
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    ShowError("Connection");
                    return;
                }
                Console.WriteLine($"Your connection object is a: {connection.GetType().Name}");
                connection.ConnectionString = connectionString;
                connection.Open();

                //Create command object
                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    ShowError("Command");
                    return;
                }
                Console.WriteLine($"Your command object is a: {command.GetType().Name}");
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";

                //Print data
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    Console.WriteLine($"Your data reader object is a: {dataReader.GetType().Name}");
                    Console.WriteLine("\n***** Drone Inventory *****");
                    while (dataReader.Read())
                        Console.WriteLine($"-> Drone #{dataReader["DroneId"]} is a {dataReader["Make"]}.");
                }
            }
            Console.ReadLine();
        }
        public static void ShowError(string objectName)
        {
            Console.WriteLine($"There was an issue creating the {objectName}");
            Console.ReadLine();
        }
    }
}//ending region
#endregion
