using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kliens_RAPC9Y_Backend.Models
{
    public class AppUser : IdentityUser
    {

        [StringLength(200)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(200)]
        [Required]
        public string LastName { get; set; }

        [StringLength(2000)]
        public string DefeatedBosses { get; set; }

    }
}
