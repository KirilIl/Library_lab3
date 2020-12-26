using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.FileAggregate;
using Library.Data.Entities.QuoteAggregate;
using Microsoft.EntityFrameworkCore;

namespace Library.EF
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<FileMetaData> FilesMetaData { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileMetaData>().HasKey(x => new { x.BookId, x.Type });
            base.OnModelCreating(modelBuilder);
        }
    }
}
