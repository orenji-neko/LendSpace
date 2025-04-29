using LendSpace.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class FacilityBookingModel
    {
        [Key]
        public string? Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public BookingStatus Status { get; set; }
        [Required]
        public DateOnly BookedAt { get; set; }

        // foreign keys
        [Required]
        public string? FacilityId { get; set; }
        [Required]
        public string? UserId { get; set; }

        public FacilityModel? Facility { get; set; }
        public UserModel? User { get; set; }
    }
}
