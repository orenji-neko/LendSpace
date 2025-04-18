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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            //optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /**
             * User[One] <-> Billing[Many]
             */
            builder.Entity<UserModel>()
                .HasMany(e => e.Billings)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
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
            builder.Entity<IdentityRole>().HasData(adminRole);
            builder.Entity<IdentityRole>().HasData(userRole);

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

            // Creating user
            // User account
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
                new BillingModel
                {
                    Id = "test-billing-0002",
                    Name = "Electricity",
                    IsPaid = false,
                    Amount = 150.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0003",
                    Name = "Water",
                    IsPaid = false,
                    Amount = 50.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0004",
                    Name = "Internet",
                    IsPaid = false,
                    Amount = 70.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0005",
                    Name = "Gas",
                    IsPaid = false,
                    Amount = 100.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0006",
                    Name = "Cable TV",
                    IsPaid = false,
                    Amount = 80.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0007",
                    Name = "Garbage Collection",
                    IsPaid = false,
                    Amount = 30.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0008",
                    Name = "Maintenance Fee",
                    IsPaid = false,
                    Amount = 125.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0009",
                    Name = "Security Fee",
                    IsPaid = false,
                    Amount = 60.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                },
                new BillingModel
                {
                    Id = "test-billing-0010",
                    Name = "Property Tax",
                    IsPaid = false,
                    Amount = 500.00,
                    UserId = "test-user-0001",
                    IssuedAt = new DateOnly(2025, 4, 2)
                }
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
        }
    }


}