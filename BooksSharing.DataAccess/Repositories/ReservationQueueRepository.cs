using BooksSharing.Application.Repositories;
using BooksSharing.DataAccess.Context;
using BooksSharing.DataAccess.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.DataAccess.Repositories
{
    public class ReservationQueueRepository : GenericRepository<ReservationQueueEntity>, IReservationQueueRepository
    {
        public ReservationQueueRepository(AppDbContext dbContext): 
            base(dbContext)
        {
            
        }
    }
}
