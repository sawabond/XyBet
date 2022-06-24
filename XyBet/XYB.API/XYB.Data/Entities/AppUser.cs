using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
 
namespace XYB.Data.Entities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Gender { get; set; } = "Male";

        [Required]
        [Range(0, 100000)]
        public double Balance { get; set; }

        public string PhotoUrl { get; set; }

        public string RefferalCode { get; set; }

        public ICollection<AppUserRole> UserRoles { get; set; }

        public ICollection<Bet> Bets { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}