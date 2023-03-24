using BooksSharing.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BooksSharing.Domain.Models
{
    public class BookEntity : BaseEntity
    {
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Author { get; set; }

        [MaxLength(200)]
        public string? Publisher { get; set; }

        [MaxLength (50)]
        public string Isbn { get; set; }

        public DateTime? PublishedDate { get; set; }

        public List<GenreEntity> Genres { get; set; }

        public int? NumberOfPages { get; set; }

        public List<TagEntity>? Tags { get; set; }


        public long ContributorId { get; set; }

        [ForeignKey(nameof(this.ContributorId))]
        public UserEntity Contributor { get; set; }

        
        public long? CurrentKeeperId { get; set; }

        [ForeignKey(nameof(this.CurrentKeeperId))]
        public UserEntity? CurrentKeeper { get; set; }
    }
}
