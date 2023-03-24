using BooksSharing.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace BooksSharing.Domain.Models
{
    public class UserEntity : BaseEntity
    {
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Surname { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? City { get; set; }

        public string? Address { get; set; }
    }
}
