using BooksSharing.Application.Repositories;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.DataAccess.Repositories
{
    public class LoanHistoryRepository : GenericRepository<LoanHistoryEntity>, ILoanHistoryRepository
    {
        public LoanHistoryRepository(AppDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
