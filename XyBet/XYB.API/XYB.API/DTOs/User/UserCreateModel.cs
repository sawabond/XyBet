using System.ComponentModel.DataAnnotations;

namespace XYB.API.DTOs.User
{
    public class UserCreateModel
    {
        [Required]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
