using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class FacilityModel
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public bool Available { get; set; }
    }
}