using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models
{
    public class Player
    {
        public Player()
        {
            PlayersStatistics = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public int SquadNumber { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; } = null!;

        public int PositionId { get; set; }

        public Position Position { get; set; } = null!;

        public bool IsInjured { get; set; }

        public ICollection<PlayerStatistic> PlayersStatistics { get; set; }
    }
}