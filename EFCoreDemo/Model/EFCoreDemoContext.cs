using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Model
{
    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
        }
    }
}