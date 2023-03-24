using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSharing.Application.Repositories.Common
{
    //Asyncronious generic repository interface for CRUD operations
    public interface IGenereicRepositoryAsync<T>
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(long id);
        Task<List<T>> GetAllAsync();
        Task<bool> ExistAsync(long id);
    }
}
