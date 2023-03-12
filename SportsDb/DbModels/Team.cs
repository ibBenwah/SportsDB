using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDb.DbModels
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string TeamName { get; set; }

        public int RosterSize { get; set; }


        //[ForeignKey(nameof(Player))]
        //[Required]
        //public  List<Player> Players { get; set; }
    }
}
