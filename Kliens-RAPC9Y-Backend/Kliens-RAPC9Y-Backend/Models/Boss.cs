using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Kliens_RAPC9Y_Backend.Models
{
    public class Boss
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(Game))]
        [Required]
        public int Game_Id { get; set; }

        [JsonIgnore]
        [NotMapped]
        [ValidateNever]
        public virtual Game Game { get; set; }

        [Required]
        public string BossName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Hp { get; set; }

        [Required]
        public int Souls { get; set; }

        [Required]
        public int Defense { get; set; }

        [Required]
        public string Image { get; set; }

        public Boss()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
