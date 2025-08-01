﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace LendSpace.Models
{
    public class UserModel : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "Middle Initial")]
        public string? MidInitial { get; set; }
        [Required]
        public string? Address { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Add a computed Name property that combines FirstName and LastName
        public string Name => $"{FirstName} {LastName}";

        public ICollection<BillingModel> Billings { get; } = new List<BillingModel>();
        public ICollection<ReservationModel> Reservations { get; } = new List<ReservationModel>();
        public ICollection<RequestModel> Requests { get; } = new List<RequestModel>();
        public ICollection<NotificationModel> Notifications { get; } = new List<NotificationModel>();
    }
}