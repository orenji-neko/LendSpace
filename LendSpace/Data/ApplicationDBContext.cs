using LendSpace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace LendSpace.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserModel, IdentityRole, string>
    {
        /**
         * Auto-generated Tables.
         */
        public DbSet<FacilityModel> Facility { get; set; }
        public DbSet<BillingModel> Billing { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<AnnouncementModel> Announcements { get; set; }
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

            // Configure the one-to-many relationship between UserModel and BillingModel
            builder.Entity<UserModel>()
                   .HasMany(u => u.Billings)
                   .WithOne(b => b.User)
                   .HasForeignKey(b => b.UserId)
                   .IsRequired();
            builder.Entity<BillingModel>()
                   .HasOne(b => b.User)
                   .WithMany(u => u.Billings)
                   .HasForeignKey(b => b.UserId)
                   .IsRequired();


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
            var user = new UserModel
            {
                Id = "test-user-0001",
                Email = "user@email.com",
                NormalizedEmail = "USER@EMAIL.COM",
                UserName = "user@email.com",
                NormalizedUserName = "USER@EMAIL.COM",
                LastName = "Doe",
                FirstName = "John",
                MidInitial = "A",
                Address = "123 User St."
            };
            user.PasswordHash = hasher.HashPassword(user, "password");
            builder.Entity<UserModel>().HasData(user);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = user.Id,
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
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know.",
                    Available = true
                },
                new FacilityModel
                {
                    Id = "test-facility-0002",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know.",
                    Available = true
                },
                new FacilityModel
                {
                    Id = "test-facility-0003",
                    Name = "Facility Name",
                    Description = "Tell me about this facility",
                    Address = "Somewhere, i don't really know.",
                    Available = true
                },
                ]);

            builder.Entity<BillingModel>().HasData(new BillingModel[]
            {
                new BillingModel
                {
                    Id = "test-billing-0001",
                    Name = "Rent",
                    IsPaid = false,
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
            builder.Entity<CommunityPostModel>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure the User relationship
            builder.Entity<CommunityPostModel>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure User relationship with CommunityCommentModel
            builder.Entity<CommunityCommentModel>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure nested comments (parent-child relationship)
            builder.Entity<CommunityCommentModel>()
                .HasOne(c => c.ParentComment)
                .WithMany(c => c.Replies)
                .HasForeignKey(c => c.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}