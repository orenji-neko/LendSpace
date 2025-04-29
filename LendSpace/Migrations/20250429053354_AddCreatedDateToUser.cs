using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedDateToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "384ee4fa-cc16-40cc-a9b2-93daeaa6a5b7", new DateTime(2025, 4, 29, 5, 33, 52, 737, DateTimeKind.Utc).AddTicks(9452), "AQAAAAIAAYagAAAAEHtHZqPDfyjcloF4/AbBoqhFKE/s99TZ8kjXaZixABByBsIO/sJDABe8q6/mk8/5Yw==", "366f1fbf-25ac-4fb9-bc47-f76b2cae8437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376faf40-379e-4372-a78d-dfca168fb00a", new DateTime(2025, 4, 29, 5, 33, 52, 614, DateTimeKind.Utc).AddTicks(7404), "AQAAAAIAAYagAAAAEECxnqKgqnbcLvv5WfNOqZrhbIc9dTNabGcHTpDAEYLL2Ie6wjbdNkL6JJRIVVJjVA==", "c1574254-eb9a-4abd-9141-96e6965bbeda" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fa0417-3a3c-4e26-bd2d-0d7dfd11dcbb", "AQAAAAIAAYagAAAAEJtHVgrGVB7rHTmU51TUpT+67mZHh0fqwcKN4n3t9tIkO5cfuQ/mDof27udW314YrA==", "18c44b13-5572-4b53-a63b-966b6b2efba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a575169c-3359-4686-9c07-3c1e3e6f34c8", "AQAAAAIAAYagAAAAEFk+r17wIUgB7mhaNx6Or4zJHMZSF0iGuBU1Pn6GMS/PiEv6rEG7Fah/ulZmBfTD2g==", "edae971c-82b3-4d89-9e91-fd323be2f19f" });
        }
    }
}
