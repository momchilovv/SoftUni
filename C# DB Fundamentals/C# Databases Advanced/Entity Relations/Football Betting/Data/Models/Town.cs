using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        public int TownId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;

        public ICollection<Team> Teams { get; set; } 
    }
}