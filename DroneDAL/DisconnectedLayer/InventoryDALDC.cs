using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DroneDAL.DisconnectedLayer
{
    public class InventoryDALDC
    {
        // Constructor with Private String variable
        private string _connectionString;
        // Private member variable
        private SqlDataAdapter _adapter = null;

        public InventoryDALDC(string connectionString)
        {
            _connectionString = connectionString;

            //configure the DataAdapter
            ConfigureAdapter(out _adapter);
        }

        //configure the ConfigureAdapter method
        private void ConfigureAdapter(out SqlDataAdapter adapter)
        {
            //adapter setting select command
            adapter = new SqlDataAdapter("Select * From Inventory", _connectionString);

            // Obtain the command objects dynamically using SqlCommandBuilder
            var builder = new SqlCommandBuilder(adapter);

        }

        public DataTable GetAllInventory()
        {
            DataTable inv = new DataTable("Inventory");
            _adapter.Fill(inv);
            return inv;
        }

        public void UpdateInventory(DataTable modifiedTable)
        {
            _adapter.Update(modifiedTable);
        }
        
    }
}
