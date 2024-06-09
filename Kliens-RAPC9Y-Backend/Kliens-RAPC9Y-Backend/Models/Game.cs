using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Kliens_RAPC9Y_Backend.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string GameName { get; set; }

        [Required]
        public int ReleaseDate { get; set; }

        [Required]
        public string GameCover { get; set; }

        [NotMapped]
        public virtual ICollection<Boss> Bosses { get; set; }

        public Game()
        {
            this.Bosses = new HashSet<Boss>();
        }

    }
}
