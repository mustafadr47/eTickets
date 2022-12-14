using eTickets.Models;
using System.Collections.Generic;
namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class, IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsunc(int id, T entity);
        Task DeleteAsync(int id);
    }
}
