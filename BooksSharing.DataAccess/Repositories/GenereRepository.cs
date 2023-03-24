using BooksSharing.Application.Repositories;
using BooksSharing.Application.Repositories.Common;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.DataAccess.Repositories
{
    public class GenereRepository : GenericRepository<GenreEntity>, IGenereRepository
    {
        public GenereRepository(AppDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
