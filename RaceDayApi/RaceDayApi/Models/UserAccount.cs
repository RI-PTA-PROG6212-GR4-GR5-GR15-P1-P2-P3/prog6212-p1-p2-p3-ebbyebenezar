

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RaceDayApi.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public required string Role { get; set; }
        
    }
}
