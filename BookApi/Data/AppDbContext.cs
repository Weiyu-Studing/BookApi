using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BorrowRecord> BorrowRecords { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<BookCategory>()
            .HasKey(book => new { book.BookId, book.CategoryId });
    }
}
