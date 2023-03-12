using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDb.DbModels
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }

        public string NameOfSport { get; set; }
        
    }
}
