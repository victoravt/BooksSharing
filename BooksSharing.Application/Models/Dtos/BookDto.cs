using BooksSharing.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;


namespace BooksSharing.Application.Models.Dtos
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public string PublishedDate { get; set; }
        public List<GenereDto> Generes { get; set; }
        public int NumberOfPages { get; set; }
        public List<TagDto> Tags { get; set; }
        public long ContributorId { get; set; }

        [ForeignKey(nameof(this.ContributorId))]
        public UserDto Contributor { get; set; }

        public long CurrentKeeperId { get; set; }

        [ForeignKey(nameof(this.CurrentKeeperId))]
        public UserDto CurrentKeeper { get; set; }
    }
}
