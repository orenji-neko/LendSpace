using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class ReviewModel
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public UserModel User { get; set; }

        [Required]
        public string FacilityId { get; set; }
        public FacilityModel Facility { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Optional: If you want to track if a review was edited
        public DateTime? UpdatedAt { get; set; }
    }
}