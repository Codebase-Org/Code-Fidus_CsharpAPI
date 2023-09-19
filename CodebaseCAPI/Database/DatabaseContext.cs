using Microsoft.EntityFrameworkCore;
using Code_Fidus_CsharpAPI.Models;

namespace Code_Fidus_CsharpAPI.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        public DbSet<roles> roles { get; set; }
        public DbSet<accounts> accounts { get; set; }
        public DbSet<profiles> profiles { get; set; }
        public DbSet<post_types> post_types { get; set; }
        public DbSet<categories> categories { get; set; }
        public DbSet<posts> posts { get; set; }
        public DbSet<answars> answars { get; set; }
        public DbSet<follows> follows { get; set; }
        public DbSet<messages> messages { get; set; }
        public DbSet<loginhistories> loginhistories { get; set; }
        public DbSet<motds> motds { get; set; }
        public DbSet<faqs> faqs { get; set; }
    }
}
