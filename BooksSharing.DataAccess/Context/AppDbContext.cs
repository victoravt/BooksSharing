using BooksSharing.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BooksSharing.DataAccess.Context
{
    public class AppDbContext : DbContext
    {        
        // All db sets
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<GenreEntity> Generes { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<LoanHistoryEntity> LoanHistory { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ReservationQueueEntity> ReservationQueue { get; set; }

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) 
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ///Set Delete behaviour of LoanHistoryEntity
            ///This is only initial set, it might be changed in the future
            
            //Books have many generes and generes have many books
            modelBuilder.Entity<BookEntity>()
                .HasMany(x=>x.Genres)
                .WithMany(x=>x.Books)
                .UsingEntity(j => j.ToTable("BooksToGenresRelationships"));

            modelBuilder.Entity<BookEntity>()
                .HasMany(x => x.Tags)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);

            //Don't let contributor be deleted if he has books
            modelBuilder.Entity<BookEntity>()
                .HasOne(x => x.Contributor)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            //If the Keeper has books, restrict the deletion
            modelBuilder.Entity<BookEntity>()
                .HasOne(x => x.CurrentKeeper)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);



            ///Set Delete behaviour of LoanHistoryEntity
            ///This is only initial set, it might be changed in the future
            modelBuilder.Entity<LoanHistoryEntity>()
                .HasOne(x => x.Book)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanHistoryEntity>()
                .HasOne(x => x.Lender)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanHistoryEntity>()
                .HasOne(x => x.Borrower)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanHistoryEntity>()
                .HasIndex(x=>x.BookId)
                .IsUnique(false);

            modelBuilder.Entity<LoanHistoryEntity>()
                .HasIndex(x => x.BorrowerId)
                .IsUnique(false);

            modelBuilder.Entity<LoanHistoryEntity>()
                .HasIndex(x => x.LenderId)
                .IsUnique(false);

            ///Set Delete behaviour of ReservationQueueEntity
            ///This is only initial set, it might be changed in the future
            modelBuilder.Entity<ReservationQueueEntity>()
                .HasOne(x => x.Book)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReservationQueueEntity>()
                .HasOne(x => x.User)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ReservationQueueEntity>()
                .HasIndex(x => x.BookId)
                .IsUnique(false);

            modelBuilder.Entity<ReservationQueueEntity>()
                .HasIndex(x => x.UserId)
                .IsUnique(false);
        }
    }
}
