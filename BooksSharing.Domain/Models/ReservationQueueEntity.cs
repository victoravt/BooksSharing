using BooksSharing.Domain.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksSharing.Domain.Models
{
    public class ReservationQueueEntity: BaseEntity
    {
        public long BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public BookEntity Book { get; set; }

        public long UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }

        public DateTime? ReservationDate { get; set; }

        public bool IsReserved { get; set; }
    }
}
