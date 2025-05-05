using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LendSpace.Models.Enums;

namespace LendSpace.Models
{
    public class ReservationModel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public UserModel? User { get; set; }

        [Required]
        public string FacilityId { get; set; }

        [ForeignKey("FacilityId")]
        public FacilityModel? Facility { get; set; }

        [Required]
        public DateOnly StartsAt { get; set; }

        [Required]
        public DateOnly EndsAt { get; set; }

        [Required]
        public int GuestCount { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public string? StaffNotes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? ReviewedAt { get; set; }

        public string? ReviewedById { get; set; }

        [ForeignKey("ReviewedById")]
        public UserModel? ReviewedBy { get; set; }
    }
}