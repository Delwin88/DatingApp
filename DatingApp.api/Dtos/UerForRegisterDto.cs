using System.ComponentModel.DataAnnotations;

namespace DatingApp.api.Dtos
{
    public class UerForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage="Password length between 4 and 8 characters")]
        public string Password { get; set; }
    }
}