using System.ComponentModel.DataAnnotations;

namespace Kliens_RAPC9Y_Backend.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        [StringLength(2000)]
        public string DefeatedBosses { get; set; }
    }
}
