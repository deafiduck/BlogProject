using Microsoft.EntityFrameworkCore;
using BlogV1.Models;
namespace BlogV1.Context
{
    public class BlogDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-N5A035R; database=BlogV1; integrated Security=True;TrustServerCertificate=True;");
        }
        //veri tabanı bağlantısı

        public DbSet<Blog> Blogs { get; set; }
    }
}
