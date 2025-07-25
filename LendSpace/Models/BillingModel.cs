﻿using LendSpace.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace LendSpace.Models
{
    public class BillingModel
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required double Amount { get; set; }

        /**
         * The user who's required to pay the bill
         */
        public UserModel? User { get; set; }
        [Required]
        public string? UserId { get; set; }

        [Required]
        public BillingStatus Status { get; set; }

        [Required]
        public DateOnly IssuedAt { get; set; }
    }
}
