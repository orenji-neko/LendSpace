using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class RequestModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string ServiceId { get; set; }

        public ServiceModel? Service { get; set; }
    }
}
