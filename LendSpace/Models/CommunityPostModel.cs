using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LendSpace.Models
{
    public class CommunityPostModel
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PostedAt { get; set; }

        public int LikeCount { get; set; } = 0;

        public int CommentCount { get; set; } = 0;

        public int ShareCount { get; set; } = 0;

        public bool IsFeatured { get; set; } = false;

        public string? Category { get; set; }

        public string? ImageUrl { get; set; }

        public double? Rating { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? User { get; set; }

        // Navigation property for comments
        public virtual ICollection<CommunityCommentModel> Comments { get; set; } = new List<CommunityCommentModel>();
    }
}