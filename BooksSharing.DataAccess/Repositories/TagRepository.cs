using BooksSharing.Application.Repositories;
using BooksSharing.Application.Repositories.Common;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.DataAccess.Repositories
{
    public class TagRepository : GenericRepository<TagEntity>, ITagRepository
    {
        public TagRepository(AppDbContext context) 
            : base(context)
        {
        }
    }
   
}
