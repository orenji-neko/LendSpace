﻿// <auto-generated />
using System;
using LendSpace.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LendSpace.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250418144846_seeding-users-2")]
    partial class seedingusers2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("LendSpace.Models.AnnouncementModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("PostedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Announcements");

                    b.HasData(
                        new
                        {
                            Id = "test-announcement-0001",
                            Body = "Details can be found here",
                            Heading = "Announcement",
                            PostedAt = new DateOnly(2025, 4, 6)
                        });
                });

            modelBuilder.Entity("LendSpace.Models.BillingModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("IssuedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Billing");

                    b.HasData(
                        new
                        {
                            Id = "test-billing-0001",
                            Amount = 2000.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Rent",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0002",
                            Amount = 150.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Electricity",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0003",
                            Amount = 50.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Water",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0004",
                            Amount = 70.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Internet",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0005",
                            Amount = 100.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Gas",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0006",
                            Amount = 80.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Cable TV",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0007",
                            Amount = 30.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Garbage Collection",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0008",
                            Amount = 125.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Maintenance Fee",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0009",
                            Amount = 60.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Security Fee",
                            UserId = "test-user-0001"
                        },
                        new
                        {
                            Id = "test-billing-0010",
                            Amount = 500.0,
                            IsPaid = false,
                            IssuedAt = new DateOnly(2025, 4, 2),
                            Name = "Property Tax",
                            UserId = "test-user-0001"
                        });
                });

            modelBuilder.Entity("LendSpace.Models.EventModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("StartedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = "test-event-0001",
                            Description = "Home Owners Association Anniversary",
                            Name = "Anniversary",
                            StartedAt = new DateOnly(2025, 4, 6)
                        },
                        new
                        {
                            Id = "test-event-0002",
                            Description = "Test Event Description",
                            Name = "Test Event 1",
                            StartedAt = new DateOnly(2025, 4, 15)
                        });
                });

            modelBuilder.Entity("LendSpace.Models.FacilityModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Facility");

                    b.HasData(
                        new
                        {
                            Id = "test-facility-0001",
                            Address = "Somewhere, i don't really know.",
                            Available = true,
                            Description = "Tell me about this facility",
                            Name = "Facility Name"
                        },
                        new
                        {
                            Id = "test-facility-0002",
                            Address = "Somewhere, i don't really know.",
                            Available = true,
                            Description = "Tell me about this facility",
                            Name = "Facility Name"
                        },
                        new
                        {
                            Id = "test-facility-0003",
                            Address = "Somewhere, i don't really know.",
                            Available = true,
                            Description = "Tell me about this facility",
                            Name = "Facility Name"
                        });
                });

            modelBuilder.Entity("LendSpace.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("MidInitial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "test-user-0001",
                            AccessFailedCount = 0,
                            Address = "123 User St.",
                            ConcurrencyStamp = "1402d0cc-d631-4ee0-a9db-cad5b7902b3a",
                            Email = "user@email.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            MidInitial = "A",
                            NormalizedEmail = "USER@EMAIL.COM",
                            NormalizedUserName = "USER@EMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJMS7hs1j4trkzc0rZsCJz4AE2xrsD10p7lP47+aetu24fxSmOnX8yb17LjpymiT7A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "711a930a-5049-4c1a-ad14-f2be7f384b8d",
                            TwoFactorEnabled = false,
                            UserName = "user@email.com"
                        },
                        new
                        {
                            Id = "test-admin-0001",
                            AccessFailedCount = 0,
                            Address = "123 Admin St.",
                            ConcurrencyStamp = "a1242d51-ced4-4328-90a0-7d591b05c0fd",
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            MidInitial = "A",
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN@EMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8561c4d9-6709-4315-9b9b-02ed81962ab2",
                            TwoFactorEnabled = false,
                            UserName = "admin@email.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "role-admin-0001",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "role-user-0001",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "test-user-0001",
                            RoleId = "role-user-0001"
                        },
                        new
                        {
                            UserId = "test-admin-0001",
                            RoleId = "role-admin-0001"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LendSpace.Models.BillingModel", b =>
                {
                    b.HasOne("LendSpace.Models.UserModel", "User")
                        .WithMany("Billings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LendSpace.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LendSpace.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LendSpace.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LendSpace.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LendSpace.Models.UserModel", b =>
                {
                    b.Navigation("Billings");
                });
#pragma warning restore 612, 618
        }
    }
}
