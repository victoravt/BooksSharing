
namespace BooksSharing.Application.Models.Dtos
{
    public class ReservationQueueDto
    {
        public long BookId { get; set; }
        public long UserId { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool IsReserved { get; set; }
    }
}
