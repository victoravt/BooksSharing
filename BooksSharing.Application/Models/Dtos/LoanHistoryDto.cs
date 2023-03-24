
namespace BooksSharing.Application.Models.Dtos
{
    public class LoanHistoryDto
    {
        public long BookId { get; set; }
        public long LenderId { get; set; }
        public long BorrowerId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
