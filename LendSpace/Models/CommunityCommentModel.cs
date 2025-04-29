using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LendSpace.Models
{
    public class CommunityCommentModel
    {
        [Key]
        public required string Id { get; set; }

        [Required]
        public required string PostId { get; set; }

        [Required]
        public required string UserId { get; set; }

        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Content { get; set; }

        [Required]
        public required DateTime PostedAt { get; set; } // Keep this as PostedAt to match your existing code

        public int LikeCount { get; set; } = 0;

        // Add support for nested comments (optional)
        public string? ParentCommentId { get; set; }

        [ForeignKey("ParentCommentId")]
        public virtual CommunityCommentModel? ParentComment { get; set; }

        public virtual ICollection<CommunityCommentModel>? Replies { get; set; }

        [ForeignKey("PostId")]
        public virtual CommunityPostModel? Post { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? User { get; set; } // Change to UserModel instead of IdentityUser
    }
}