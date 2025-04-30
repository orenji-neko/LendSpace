using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace LendSpace.Models
{
    public class UserModel : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "Middle Initial")]
        public string? MidInitial { get; set; }
        [Required]
        public string? Address { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public ICollection<BillingModel> Billings { get; } = new List<BillingModel>();
        [Required]
        public ICollection<ReservationModel> Reservations { get; } = new List<ReservationModel>();
    }
}