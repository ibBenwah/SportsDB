using Microsoft.EntityFrameworkCore;

namespace SportsDb.DbModels
{
    public class LeagueInfoDbContext: DbContext
    {
        public LeagueInfoDbContext(DbContextOptions<LeagueInfoDbContext> options) : base(options) { }
        
        public DbSet<LeagueInfo> LeagueInfo { get; set; }
    }
}
