using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    /// <summary>
    /// Model for Services provided by the subdivision.
    /// </summary>
    public class ServiceModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required double Pricing { get; set; } // per day

        [Required]
        public required bool Available { get; set; }
    }
}
