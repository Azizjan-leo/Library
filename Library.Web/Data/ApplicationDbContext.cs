using Library.Web.Data.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Writer>()
                .HasIndex(x => x.Name);
            
            builder.Entity<Book>()
                .HasIndex(x => x.Title); 
            
            builder.Entity<ReadBook>()
                .ToView(null);

            WritersAndBooksSeed.SeedWritersAndBooks(builder);

            base.OnModelCreating(builder);
        }

        public DbSet<Writer> Writers => Set<Writer>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<ReadBook> ReadBooks => Set<ReadBook>();
    }
}
