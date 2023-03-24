using BooksSharing.Application.Repositories.Common;
using BooksSharing.DataAccess.Context;
using BooksSharing.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace BooksSharing.DataAccess.Repositories.Common
{
    //Represents base repository for all entities
    //It contains basic CRUD operations
    public class GenericRepository<T> : IGenereicRepositoryAsync<T> where T : BaseEntity
    {
        //Database context
        protected readonly AppDbContext _dbContext;
        //Database table
        protected readonly DbSet<T> _dbSet;

        //Constructor
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        //Add new entity to database
        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        //Delete entity from database
        public virtual async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        //Get all entities from database
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        //Get entity by id from database
        public virtual async Task<T> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        //Check if entity exists in database
        public virtual async Task<bool> ExistAsync(long id)
        {
            return await _dbSet.AnyAsync(x => x.Id == id);
        }

        //Update entity in database
        public virtual async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }
    }
}
