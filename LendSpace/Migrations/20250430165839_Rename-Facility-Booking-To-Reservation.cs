using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class RenameFacilityBookingToReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacilityBookings");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    BookedAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    FacilityId = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "121670ff-1b91-4a69-a3cf-136cca027b9c", new DateTime(2025, 4, 30, 16, 58, 38, 456, DateTimeKind.Utc).AddTicks(5246), "AQAAAAIAAYagAAAAENWb+Hq4hq6JHRGhYrA/0W/IeMlW3MtJJn/2feGP85xcM2lXDcqq2laGc7voX/1+tA==", "3b4bc1f3-885c-4a56-ada3-61de800e5656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8540d4eb-e049-485d-a72c-4d4741c76325", new DateTime(2025, 4, 30, 16, 58, 38, 506, DateTimeKind.Utc).AddTicks(9446), "AQAAAAIAAYagAAAAEH39vOSQJkp9W7nJEl48T2RWVFfx14UyxQRj72z98p0ajNMAz+UEGZINa4UqmbXnOw==", "3348d5ac-8ad0-4e94-ad80-d025328347ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05e0836e-4f89-4425-821c-da0daecf998b", new DateTime(2025, 4, 30, 16, 58, 38, 343, DateTimeKind.Utc).AddTicks(2690), "AQAAAAIAAYagAAAAEHh/1g2CuMO/zvjGRkBsSGqGExc6aoQt/P0XpV/OVKzmMngMDmeYqHiOSMRNJfMXNw==", "2fb3969e-ebf7-4e90-a191-2fb71d631ffc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0af4ce-3806-4167-b07c-97e1667e59ab", new DateTime(2025, 4, 30, 16, 58, 38, 395, DateTimeKind.Utc).AddTicks(3085), "AQAAAAIAAYagAAAAEO3f+tfzmjY6tXW7hfG0TaJAEisFmqCuhfZOIrH9LPPepyrRtZSKrgchhIJRon0MPA==", "9dd8f2db-e81e-433f-b521-24dfd566b18b" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FacilityId",
                table: "Reservations",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.CreateTable(
                name: "FacilityBookings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FacilityId = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    BookedAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityBookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityBookings_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608107ab-026b-4893-a216-8fa4e1883abd", new DateTime(2025, 4, 29, 17, 18, 28, 212, DateTimeKind.Utc).AddTicks(3967), "AQAAAAIAAYagAAAAEHuuh6r4f2KKcHeUcEcD9AuftrYriArkyY6/e1XSrVJXAEDXJ4NjbWuyabTirCp05w==", "0ca353b7-cf49-4c3b-b8ba-5a7dfe0c2394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cda5251-db17-442a-b486-3c84194e3ae6", new DateTime(2025, 4, 29, 17, 18, 28, 264, DateTimeKind.Utc).AddTicks(1645), "AQAAAAIAAYagAAAAEI7e+7/TkwNGe6vztm5c7LWYZxoP+ZSZOgPjCNV61aw0XSYpJ/m7xW8ZyZORFeBCBw==", "0064fdde-90e2-49c6-bf9c-7d4a48fc2804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de83496f-f4d1-42d5-a69a-5f3d4731a672", new DateTime(2025, 4, 29, 17, 18, 28, 104, DateTimeKind.Utc).AddTicks(3194), "AQAAAAIAAYagAAAAEHcIPO3A2d28WuMwiN83wHPupBwE7rg1i8ioBNsxft2o0e6DHjUjFKGb79pYpFkuNw==", "b3f2a647-79d8-4d3c-89b2-0031dc5ee736" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a84a43-c9e0-469e-a252-303a3df4f639", new DateTime(2025, 4, 29, 17, 18, 28, 160, DateTimeKind.Utc).AddTicks(1979), "AQAAAAIAAYagAAAAEF0JzZVybRZ+ASJ/b3buB2AwlpI6iMR0zZh2xvLiTjb0dO7lGxviVJIaJejEj+jnWg==", "e4fa30a5-51bd-42a7-8550-74f1657d1d1f" });

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_FacilityId",
                table: "FacilityBookings",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_UserId",
                table: "FacilityBookings",
                column: "UserId");
        }
    }
}
