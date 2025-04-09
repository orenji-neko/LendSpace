using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingevents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0d4b20-e8d8-431a-8acc-9c522c1a0bed", "AQAAAAIAAYagAAAAEDkMgU28HXV5Qsg7kRJ9rQPmp4d5nWeFtzFcWCbmBfROuRwUB2t95trPyrFHLkLgZA==", "6b235b60-83c5-4ef7-844c-b54f3dd154d3" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0002",
                column: "StartedAt",
                value: new DateOnly(2025, 4, 15));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf83904-b4a8-432f-a78b-5c76641d1d42", "AQAAAAIAAYagAAAAEPx2OWJbcJ8WNL3inwuaQed3h2k8XdVky5rSGbkRbf8b1PJDxOGCelAl0F6t6L5IPA==", "2f3b0e22-2418-42a7-b47c-e77b0fb98fff" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0002",
                column: "StartedAt",
                value: new DateOnly(2025, 4, 6));
        }
    }
}
