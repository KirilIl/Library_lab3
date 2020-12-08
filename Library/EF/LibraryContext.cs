using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.FileAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public virtual DbSet<File> Files { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
