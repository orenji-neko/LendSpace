using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class AnnouncementModel
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Heading { get; set; }

        [Required]
        public required string Body { get; set; }

        [Required]
        public required DateOnly PostedAt { get; set; }
    }
}
