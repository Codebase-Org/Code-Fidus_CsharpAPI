using Microsoft.EntityFrameworkCore;
using CodebaseCAPI.Models;

namespace CodebaseCAPI.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        public DbSet<role> roles { get; set; }
        public DbSet<account> accounts { get; set; }
        public DbSet<profile> profiles { get; set; }
        public DbSet<post_type> post_types { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<post> posts { get; set; }
        public DbSet<answar> answars { get; set; }
        public DbSet<follow> follows { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<login_history> login_histories { get; set; }
        public DbSet<motd> motds { get; set; }
        public DbSet<faq> faqs { get; set; }
        public DbSet<education> educations { get; set; }
    }
}
