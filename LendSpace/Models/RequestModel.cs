using System.ComponentModel.DataAnnotations;
using LendSpace.Models.Enums;

namespace LendSpace.Models
{
    public class RequestModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public DateOnly StartsAt { get; set; }

        [Required]
        public DateOnly EndsAt { get; set; }

        [Required]
        public RequestStatus Status { get; set; }

        [Required]
        public string? ServiceId { get; set; }
        public ServiceModel? Service { get; set; }

        [Required]
        public string? UserId { get; set; }
        public UserModel? User { get; set; }
    }
}