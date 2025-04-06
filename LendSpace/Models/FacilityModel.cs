using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class FacilityModel
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Address { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public bool? Available { get; set; }
    }
}
