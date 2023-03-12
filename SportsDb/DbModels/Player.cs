using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace SportsDb.DbModels
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public int PlayerId { get; set; }
        
        public string PlayerName { get; set; }
    }
}
