using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingannouncements1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Heading = table.Column<string>(type: "TEXT", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    PostedAt = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Body", "Heading", "PostedAt" },
                values: new object[] { "test-announcement-0001", "Details can be found here", "Announcement", new DateOnly(2025, 4, 6) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf83904-b4a8-432f-a78b-5c76641d1d42", "AQAAAAIAAYagAAAAEPx2OWJbcJ8WNL3inwuaQed3h2k8XdVky5rSGbkRbf8b1PJDxOGCelAl0F6t6L5IPA==", "2f3b0e22-2418-42a7-b47c-e77b0fb98fff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc0b930d-367d-45c5-a604-fe1af7b36d22", "AQAAAAIAAYagAAAAEHLovzokhVGjtbFCpQSSl4r5JXUPVmR3pReIDZaHX1R+z545Hx4F8cDapxPxPtbYpA==", "0337037d-1c25-4b3a-9b36-411a7cff610f" });
        }
    }
}
