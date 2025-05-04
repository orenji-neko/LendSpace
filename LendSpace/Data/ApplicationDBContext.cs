using LendSpace.Models;
using LendSpace.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel;

namespace LendSpace.Data
{
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
            dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
            dateTime => DateOnly.FromDateTime(dateTime))
        {
        }
    }

    // DateOnly value comparer for Entity Framework Core
    public class DateOnlyComparer : ValueComparer<DateOnly>
    {
        public DateOnlyComparer() : base(
            (d1, d2) => d1.DayNumber == d2.DayNumber,
            d => d.GetHashCode())
        {
        }
    }
    public class ApplicationDbContext : IdentityDbContext<UserModel, IdentityRole, string>
    {
        public DbSet<FacilityModel> Facility { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }

        public DbSet<ServiceModel> Services { get; set; }
        public DbSet<RequestModel> Requests { get; set; }

        public DbSet<BillingModel> Billing { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<AnnouncementModel> Announcements { get; set; }
        public DbSet<NotificationModel> Notifications { get; set; }

        public DbSet<CommunityPostModel> CommunityPosts { get; set; }
        public DbSet<CommunityCommentModel> CommunityComments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // User billilngs
            builder.Entity<UserModel>()
                .HasMany(u => u.Billings)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                .IsRequired();
            // User Requests
            builder.Entity<UserModel>()
                .HasMany(u => u.Requests)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .IsRequired();
            // User Reservations
            builder.Entity<UserModel>()
                .HasMany(u => u.Reservations)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                .IsRequired();
            // User Notifications
            builder.Entity<UserModel>()
            .HasMany<NotificationModel>()
            .WithOne(n => n.User)
            .HasForeignKey(n => n.UserId)
            .IsRequired();

            builder.Entity<NotificationModel>()
            .Property(n => n.CreatedAt)
            .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            // Billing -> User
            builder.Entity<BillingModel>()
                .HasOne(b => b.User)
                .WithMany(u => u.Billings)
                .HasForeignKey(b => b.UserId)
                .IsRequired();

            // Reservation -> User
            builder.Entity<ReservationModel>()
                .HasOne(fb => fb.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(fb => fb.UserId)
                .IsRequired();

            // Request -> User
            builder.Entity<RequestModel>()
                .HasOne(r => r.User)
                .WithMany(u => u.Requests)
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            // CommunityPostModel[one] - CommunityCommentModel[many]
            builder.Entity<CommunityPostModel>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);
            // CommunityPostModel[many]- UserModel[one] 
            builder.Entity<CommunityPostModel>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            // CommunityCommentModel[many]- UserModel[one] 
            builder.Entity<CommunityCommentModel>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            // CommunityCommentModel[one, parent] - CommunityCommentModel[many, child]
            builder.Entity<CommunityCommentModel>()
                .HasOne(c => c.ParentComment)
                .WithMany(c => c.Replies)
                .HasForeignKey(c => c.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            // seeding table operations. remove in production
            SeedTables(builder);
        }

        private void SeedTables(ModelBuilder builder)
        {
            // password hashing bullshit
            var hasher = new PasswordHasher<UserModel>();

            // Role seeding
            var adminRole = new IdentityRole
            {
                Id = "role-admin-0001",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            var userRole = new IdentityRole
            {
                Id = "role-user-0001",
                Name = "User",
                NormalizedName = "USER"
            };
            var staffRole = new IdentityRole
            {
                Id = "role-staff-0001",
                Name = "Staff",
                NormalizedName = "STAFF"
            };
            builder.Entity<IdentityRole>().HasData(adminRole);
            builder.Entity<IdentityRole>().HasData(userRole);
            builder.Entity<IdentityRole>().HasData(staffRole);

            // Creating user
            // User account
            var user1 = new UserModel
            {
                Id = "test-user-0001",
                Email = "user1@email.com",
                NormalizedEmail = "USER1@EMAIL.COM",
                UserName = "user1@email.com",
                NormalizedUserName = "USER1@EMAIL.COM",
                LastName = "Dal",
                FirstName = "Ian John",
                MidInitial = "L",
                Address = "Cebu City"
            };
            user1.PasswordHash = hasher.HashPassword(user1, "password");
            builder.Entity<UserModel>().HasData(user1);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = user1.Id,
                });
            var user2 = new UserModel
            {
                Id = "test-user-0002",
                Email = "user2@email.com",
                NormalizedEmail = "USER2@EMAIL.COM",
                UserName = "user2@email.com",
                NormalizedUserName = "USER2@EMAIL.COM",
                LastName = "Yancha",
                FirstName = "Christian",
                MidInitial = "D",
                Address = "Basey, Samar"
            };
            user2.PasswordHash = hasher.HashPassword(user2, "password");
            builder.Entity<UserModel>().HasData(user2);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = user2.Id,
                });

            // Creating admin
            // Admin account
            var admin = new UserModel
            {
                Id = "test-admin-0001",
                Email = "admin@email.com",
                NormalizedEmail = "ADMIN@EMAIL.COM",
                UserName = "admin@email.com",
                NormalizedUserName = "ADMIN@EMAIL.COM",
                LastName = "Doe",
                FirstName = "John",
                MidInitial = "A",
                Address = "123 Admin St."
            };
            admin.PasswordHash = hasher.HashPassword(admin, "password");
            builder.Entity<UserModel>().HasData(admin);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRole.Id,
                    UserId = admin.Id,
                });

            // Creating staff
            // Staff account
            var staff = new UserModel
            {
                Id = "test-staff-0001",
                Email = "staff@email.com",
                NormalizedEmail = "STAFF@EMAIL.COM",
                UserName = "staff@email.com",
                NormalizedUserName = "STAFF@EMAIL.COM",
                LastName = "Smith",
                FirstName = "Jane",
                MidInitial = "B",
                Address = "123 Staff St."
            };
            staff.PasswordHash = hasher.HashPassword(staff, "password");
            builder.Entity<UserModel>().HasData(staff);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = staffRole.Id,
                    UserId = staff.Id,
                });

            // Facility seeding
            builder.Entity<FacilityModel>().HasData([
                new FacilityModel
                {
                    Id = "test-facility-0001",
                    Name = "Swimming Pool",
                    Description = "A big tub, with water!",
                    Address = "Biringan City, Samar",
                    Available = true,
                    Pricing = 200.00
                },
                ]);

            builder.Entity<BillingModel>().HasData(new BillingModel[]
            {
                new BillingModel
                {
                    Id = "test-billing-0001",
                    Name = "Rent",
                    Status = BillingStatus.Unpaid,
                    Amount = 2000.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
            });

            // Event Seeding
            builder.Entity<EventModel>().HasData([
                new EventModel
                {
                    Id = "test-event-0001",
                    Name = "Anniversary",
                    Description = "Home Owners Association Anniversary",
                    StartedAt = new DateOnly(2025, 4, 6)
                },
                new EventModel
                {
                    Id = "test-event-0002",
                    Name = "Test Event 1",
                    Description = "Test Event Description",
                    StartedAt = new DateOnly(2025, 4, 15)
                },
                ]);

            // Announcement Seeding
            builder.Entity<AnnouncementModel>().HasData([
                new AnnouncementModel
                {
                    Id = "test-announcement-0001",
                    Heading = "Announcement",
                    Body = "Details can be found here",
                    PostedAt = new DateOnly(2025, 4, 6)
                }
                ]);

            // Notification Seeding
            builder.Entity<NotificationModel>().HasData([
                new NotificationModel
                {
                    Id = "test-notification-0001",
                    UserId = "test-user-0001",
                    Title = "Welcome to LendSpace",
                    Message = "Thank you for joining our community!",
                    CreatedAt = new DateOnly(2025, 4, 6),
                    IsRead = false,
                    Type = NotificationType.General,
                    Link = "/dashboard" // Added the Link property
                }
                ]);

        }
    }
}