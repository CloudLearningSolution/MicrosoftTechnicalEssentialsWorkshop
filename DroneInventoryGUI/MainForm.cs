using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DroneDAL.DisconnectedLayer;
using DroneDAL;
using DroneDAL.EF;
using DroneDAL.Models;
using DroneDAL.Repos;

namespace DroneInventoryGUI
{
    
    public partial class MainForm : Form
    {
        private InventoryDALDC _dal = null;
        #region Use code data access object to connect to a local or cloud database like; Google, Microsoft, Amazon.
        public MainForm()
        {
            InitializeComponent();
            string connectionString = @"data source=(LocalDb)\MSSQLLocalDB;initial catalog=DroneDb;integrated security=True;Pooling=False";

            //create our data access object
            _dal = new InventoryDALDC(connectionString);

            //fill up our data grid
            droneGridView.DataSource = _dal.GetAllInventory();
        }
        #endregion

        #region Button to update data grid V1
        //TODO : add btnUpdateInventory_Click Method
        /*
        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            //update data from drone grid.
            DataTable changedDT = (DataTable)droneGridView.DataSource;
            try
            {
                //commit changes
                _dal.UpdateInventory(changedDT);
                droneGridView.DataSource = _dal.GetAllInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        #endregion

        #region Button to update drone data grid view Version 2
        private void btnUpdateInventory_Click_1(object sender, EventArgs e)
        {
            //get updated data from grid.
            DataTable changedDT = (DataTable)droneGridView.DataSource;
            try
            {
                //commit changes
                _dal.UpdateInventory(changedDT);
                droneGridView.DataSource = _dal.GetAllInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
