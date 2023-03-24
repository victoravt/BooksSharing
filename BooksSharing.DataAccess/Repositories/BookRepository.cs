using BooksSharing.Application.Repositories;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<BookEntity>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            
        }
    }
}
