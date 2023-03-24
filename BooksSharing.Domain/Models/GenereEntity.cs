using BooksSharing.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksSharing.Domain.Models
{
    [Table("Genres")]
    public class GenreEntity : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(3000)]
        public string? Description { get; set; }

        //Navigation property
        public List<BookEntity>? Books { get; set; }
    }
}
