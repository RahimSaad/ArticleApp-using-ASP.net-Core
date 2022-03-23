using Microsoft.EntityFrameworkCore;

namespace ArticlesApp.Models
{
    public class ArticlesContext : DbContext
    {
        public DbSet<Article> tbArticle { get; set; }
        public ArticlesContext() 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O9V2BHL;Database=Articles;Trusted_Connection=true;");
        }

    }
}
