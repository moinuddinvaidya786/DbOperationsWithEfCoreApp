using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEfCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }  
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Title = "USD", Description = "United States Dollar" },
                new Currency { Id = 2, Title = "EUR", Description = "Euro" },
                new Currency { Id = 3, Title = "GBP", Description = "British Pound Sterling" },
                new Currency { Id = 4, Title = "JPY", Description = "Japanese Yen" },
                new Currency { Id = 5, Title = "AUD", Description = "Australian Dollar" },
                new Currency { Id = 6, Title = "CAD", Description = "Canadian Dollar" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Title = "English", Description = "English Language" },
                new Language { Id = 2, Title = "Spanish", Description = "Spanish Language" },
                new Language { Id = 3, Title = "French", Description = "French Language" },
                new Language { Id = 4, Title = "German", Description = "German Language" },
                new Language { Id = 5, Title = "Japanese", Description = "Japanese Language" },
                new Language { Id = 6, Title = "Chinese", Description = "Chinese Language" },
                new Language { Id = 7, Title = "Russian", Description = "Russian Language" }
                );
        }
    }
}
