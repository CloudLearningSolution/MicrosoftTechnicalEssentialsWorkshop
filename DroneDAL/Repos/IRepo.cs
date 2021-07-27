using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneDAL.Models;

namespace DroneDAL.Repos
{
    //TODO 8. What does an interface type expose?
    interface IRepo<T>
    {
        int Add(T entity);
        Task<int> AddAsync(T entity);
        int AddRange(IList<T> entities);
        Task<int> AddRangeAsync(IList<T> entities);
        int Save(T entity);
        Task<int> SaveAsync(T entity);
        int Delete(int id);
        Task<int> DeleteAsync(int id);
        int Delete(T entity);
        Task<int> DeleteAsync(T entity);
        T GetOne(int? id);
        Task<T> GetOneAsync(int? id);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();

        //The members below allow for passing in string SQL query. These methods will load the entities into the DbSet<T>.
        //List<T> ExecuteQuery(string sql);
        Task<List<T>> ExecuteQueryAsync(string sql);
        List<T> ExecuteQuery(string sql, object[] sqlParametersObjects);
        Task<List<T>> ExecuteQueryAsync(string sql, object[] sqlParametersObjects);
    }
}
