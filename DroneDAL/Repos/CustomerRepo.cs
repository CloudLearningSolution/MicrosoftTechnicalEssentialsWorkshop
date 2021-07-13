using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneDAL.Models;
using System.Data.Entity;

namespace DroneDAL.Repos
{
    public class CustomerRepo:BaseRepo<Customer>,IRepo<Customer>
    {
        public CustomerRepo()
        {
            Table = Context.Customers;
        }
        public int Delete(int id)//Deleting records by Id
        {
            Context.Entry(new Customer() { CustId = id}).State = EntityState.Deleted;
            return SaveChanges();
        }
        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Customer() { CustId = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        /*public void Dispose()
        {
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }*/
    }
}
