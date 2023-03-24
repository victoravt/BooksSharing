using BooksSharing.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace BooksSharing.Domain.Models
{
    public class TagEntity : BaseEntity
    {
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(3000)]
        public string Description { get; set; }
    }
}
