using BooksSharing.Domain.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksSharing.Domain.Models
{
    public class LoanHistoryEntity : BaseEntity
    {
        public long BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public BookEntity Book { get; set; }


        public long LenderId { get; set; }

        [ForeignKey(nameof(LenderId))]
        public UserEntity Lender { get; set; }


        public long BorrowerId { get; set; }

        [ForeignKey(nameof(BorrowerId))]
        public UserEntity Borrower { get; set; }


        public DateTime? LoanDate { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsReturned { get; set; }
    }
}
