using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

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
    }
}
