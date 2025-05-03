using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class ServiceModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }
    }
}
