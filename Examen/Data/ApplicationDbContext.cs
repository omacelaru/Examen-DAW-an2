using Examen.Models.Author;
using Examen.Models.Book;
using Examen.Models.BookAuthor;
using Examen.Models.PublishingHouse;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(t => new { t.BookId, t.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(pt => pt.Book)
                .WithMany(p => p.Authors)
                .HasForeignKey(pt => pt.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(pt => pt.Author)
                .WithMany(t => t.Books)
                .HasForeignKey(pt => pt.AuthorId);

            modelBuilder.Entity<Author>()
                .HasOne(pt => pt.PublishingHouse)
                .WithMany(t => t.Authors)
                .HasForeignKey(pt => pt.PublishingHouseId);

            base.OnModelCreating(modelBuilder);
        }
    }
}