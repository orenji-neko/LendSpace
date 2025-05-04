using LendSpace.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class EventModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required DateOnly StartsAt { get; set; }

        [Required]
        public required DateOnly EndsAt { get; set; }

        public EventStatus Status { get; set; }
    }
}
