using Microsoft.EntityFrameworkCore;
using ChallengeComplain.Model;

namespace ChallengeComplain.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Complain> Complaints { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Locale> Locales { get; set; }
    }
}