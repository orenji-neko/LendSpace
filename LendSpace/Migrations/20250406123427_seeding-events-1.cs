using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingevents1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc0b930d-367d-45c5-a604-fe1af7b36d22", "AQAAAAIAAYagAAAAEHLovzokhVGjtbFCpQSSl4r5JXUPVmR3pReIDZaHX1R+z545Hx4F8cDapxPxPtbYpA==", "0337037d-1c25-4b3a-9b36-411a7cff610f" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Name", "StartedAt" },
                values: new object[,]
                {
                    { "test-event-0001", "Home Owners Association Anniversary", "Anniversary", new DateOnly(2025, 4, 6) },
                    { "test-event-0002", "Test Event Description", "Test Event 1", new DateOnly(2025, 4, 6) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0001");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0002");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89827eae-889a-44cb-ad4a-cc1f0d6a3709", "AQAAAAIAAYagAAAAEE1f/+iqbqixEZGC5gHNr1d6ElLDs1A+JO7YaZnNEkcRkNqlr5ynm7XHATeDrkLHjg==", "967ff6b8-da69-49e2-8692-878799a37268" });
        }
    }
}
