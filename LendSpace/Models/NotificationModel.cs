using LendSpace.Models.Enums;
using System;

namespace LendSpace.Models
{
    public class NotificationModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public UserModel User { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateOnly CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public NotificationType Type { get; set; }
        public string Link { get; set; }
    }
}