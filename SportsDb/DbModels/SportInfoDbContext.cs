using Microsoft.EntityFrameworkCore;

namespace SportsDb.DbModels
{
    public class SportInfoDbContext: DbContext
    {
        public SportInfoDbContext(DbContextOptions<SportInfoDbContext> options) : base(options) { }
        
        public DbSet<League> Leagues { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        
    }
}
