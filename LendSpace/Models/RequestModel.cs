using LendSpace.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    /// <summary>
    /// Service Request Model, to request a specific service to the subdivision.
    /// </summary>
    public class RequestModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required DateOnly StartsAt { get; set; }

        [Required]
        public required DateOnly EndsAt { get; set; }

        [Required]
        public required RequestStatus Status { get; set; }


        [Required]
        public required string ServiceId { get; set; }

        [Required]
        public required string UserId { get; set; }

        /// <summary>
        /// The service requested.
        /// </summary>
        public ServiceModel? Service { get; set; }
        /// <summary>
        /// The user who requested for the particular service.
        /// </summary>
        public UserModel? User { get; set; }
    }
}
