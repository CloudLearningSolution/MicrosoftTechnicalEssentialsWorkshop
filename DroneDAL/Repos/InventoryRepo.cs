using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneDAL.Models;
using System.Data.Entity;
using DroneDAL.Repos;


namespace DroneDAL.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>, IRepo<Inventory>
    {
        public InventoryRepo()
        {
            Table = Context.Inventory;
        }
        public int Delete(int id)
        {
            Context.Entry(new Inventory() { DroneId = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Inventory() { DroneId = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
