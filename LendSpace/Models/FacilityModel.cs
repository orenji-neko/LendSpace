using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class FacilityModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public double Pricing { get; set; } // per day

        [Required]
        public bool Available { get; set; }

        public string? ImagePath { get; set; }
    }
}