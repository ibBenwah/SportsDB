using System.ComponentModel.DataAnnotations;

namespace SportsDb.DbContext
{
    public class LeagueInfo
    {
        [Key]
        public string LeagueId { get; set; }
        public int NumberOfTeams { get; set; }
        public string Sport { get; set; }
    }
}
