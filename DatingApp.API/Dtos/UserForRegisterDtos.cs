using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 6, ErrorMessage="Your password length should be between 6 to 14 characters")]
        public string Password { get; set; }
    }
}