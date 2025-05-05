using LendSpace.Data;
using LendSpace.Models;
using LendSpace.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendSpace.Services
{
    public class NotificationServices
    {
        private readonly ApplicationDbContext _context;

        public NotificationServices(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new notification for a specific user
        /// </summary>
        public async Task CreateNotificationAsync(string userId, string title, string message,
            NotificationType type = NotificationType.Info, string link = null)
        {
            var notification = new NotificationModel
            {
                Id = Guid.NewGuid().ToString(),
                UserId = userId,
                Title = title,
                Message = message,
                Type = type,
                Link = link,
                CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow),
                IsRead = false
            };

            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Creates notifications for multiple users
        /// </summary>
        public async Task CreateNotificationsAsync(List<string> userIds, string title, string message,
            NotificationType type = NotificationType.Info, string link = null)
        {
            var notifications = userIds.Select(userId => new NotificationModel
            {
                Id = Guid.NewGuid().ToString(),
                UserId = userId,
                Title = title,
                Message = message,
                Type = type,
                Link = link,
                CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow),
                IsRead = false
            }).ToList();

            _context.Notifications.AddRange(notifications);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all notifications for a specific user
        /// </summary>
        public async Task<List<NotificationModel>> GetNotificationsAsync(string userId, bool includeRead = true)
        {
            return await _context.Notifications
                .Where(n => n.UserId == userId && (includeRead || !n.IsRead))
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        /// <summary>
        /// Marks a notification as read
        /// </summary>
        public async Task MarkAsReadAsync(string notificationId)
        {
            var notification = await _context.Notifications.FindAsync(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Marks all notifications as read for a specific user
        /// </summary>
        public async Task MarkAllAsReadAsync(string userId)
        {
            var notifications = await _context.Notifications
                .Where(n => n.UserId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the count of unread notifications for a specific user
        /// </summary>
        public async Task<int> GetUnreadCountAsync(string userId)
        {
            return await _context.Notifications
                .Where(n => n.UserId == userId && !n.IsRead)
                .CountAsync();
        }

        /// <summary>
        /// Deletes a notification
        /// </summary>
        public async Task DeleteNotificationAsync(string notificationId)
        {
            var notification = await _context.Notifications.FindAsync(notificationId);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Deletes all notifications for a specific user
        /// </summary>
        public async Task DeleteAllNotificationsAsync(string userId)
        {
            var notifications = await _context.Notifications
                .Where(n => n.UserId == userId)
                .ToListAsync();

            _context.Notifications.RemoveRange(notifications);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes read notifications older than the specified number of days
        /// </summary>
        public async Task CleanupOldNotificationsAsync(int olderThanDays = 30)
        {
            var cutoffDate = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-olderThanDays));

            var oldNotifications = await _context.Notifications
                .Where(n => n.IsRead && n.CreatedAt < cutoffDate)
                .ToListAsync();

            _context.Notifications.RemoveRange(oldNotifications);
            await _context.SaveChangesAsync();
        }
    }
}