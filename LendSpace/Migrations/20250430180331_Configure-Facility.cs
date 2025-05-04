using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureFacility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookedAt",
                table: "Reservations",
                newName: "StartsAt");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndsAt",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<double>(
                name: "Pricing",
                table: "Facility",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa80c21e-4b16-4399-a68c-d4fa85522fd2", new DateTime(2025, 4, 30, 18, 3, 30, 924, DateTimeKind.Utc).AddTicks(6605), "AQAAAAIAAYagAAAAEPsEbzZ31TsAwxNMIqymfRMHq/RSYqInNTehX5iTbCwTLIUM7b4Xk8fULq3KWoDJ3Q==", "5f160d6b-d566-4520-8510-d62b22f861e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "346a9cca-d49f-44a2-b81b-862745ae011d", new DateTime(2025, 4, 30, 18, 3, 30, 969, DateTimeKind.Utc).AddTicks(9423), "AQAAAAIAAYagAAAAEIy8qQpR2N7Axu1GzeHr+04wi1CtaC+cYoVpXaFAmLWK/j5G+RadmnkBYlUlakW+fA==", "6d35a731-e525-4b94-984b-9f6cb414349d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f1ff4a-ddb7-48ee-87a7-fd656830998b", new DateTime(2025, 4, 30, 18, 3, 30, 831, DateTimeKind.Utc).AddTicks(2936), "AQAAAAIAAYagAAAAEEofsGm8kXHMyz7sFAjjH4j/xc5EgU/jL90M6MQvNJanS0O+5kHvOEP1vJS2+jK8WQ==", "f5f99b33-6853-4d77-9cd3-a0513924fc2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a42c96e3-ad30-4a77-859f-5a64aa5e30af", new DateTime(2025, 4, 30, 18, 3, 30, 877, DateTimeKind.Utc).AddTicks(5585), "AQAAAAIAAYagAAAAECNmSYa0UUljRdUu5QruCqsHfJ6jMc+eVH01EcWpmFzdqZep3nGcS7B8bVKQKLGFzg==", "3ec677d3-66c1-4a73-8678-5f9f62b912b4" });

            migrationBuilder.UpdateData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                column: "Pricing",
                value: 200.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndsAt",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Pricing",
                table: "Facility");

            migrationBuilder.RenameColumn(
                name: "StartsAt",
                table: "Reservations",
                newName: "BookedAt");

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
        }
    }
}
