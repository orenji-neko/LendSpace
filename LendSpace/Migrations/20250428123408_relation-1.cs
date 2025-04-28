using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class relation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0002");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0003");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0004");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0005");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0006");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0007");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0008");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0009");

            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0010");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "267f3bfd-b707-4045-9768-61b43648a73f", "AQAAAAIAAYagAAAAELS8FhOIe3QnI98LeBMhLQQg+9tGc7VENL/aRGSbzegcBtyYIrfsNw/mCYn3PiyIrQ==", "136c6bf4-75d2-4588-b65e-dc9ddd61ab04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a941f0a-fbd1-427c-aaef-47d84be2a310", "AQAAAAIAAYagAAAAEKe3OuS7f2EPGT2SnkFcKBh+BssmKtLBTh8CwTrv+cOkJWU7bF3rDMkaWVGjD4tLtA==", "c56f11c0-75ad-4f25-b28f-9ea67b1fc630" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c357b207-8d1d-4c25-b2c0-a3e1d185f0fa", "AQAAAAIAAYagAAAAEEEBwb7Ttogzgi84tSjVUDhjFRtBMZQyqz9NaZyuB/yPkDCe5lCO3hMFc4L5UI7wkw==", "6865f4e2-28ac-409e-b32e-3080744bb5cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea4355eb-f185-47c6-ab5d-502fe4e8ad3c", "AQAAAAIAAYagAAAAEDSZnRQOxbczuakmpAUA8skLa1JJK4zXztpSWQhxdNa3yoozQqVGwyOetOXgUTx85Q==", "65578b75-a952-4b88-b6b0-de6dbf2150b1" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "Amount", "IsPaid", "IssuedAt", "Name", "UserId" },
                values: new object[,]
                {
                    { "test-billing-0002", 150.0, false, new DateOnly(2025, 4, 2), "Electricity", "test-user-0001" },
                    { "test-billing-0003", 50.0, false, new DateOnly(2025, 4, 2), "Water", "test-user-0001" },
                    { "test-billing-0004", 70.0, false, new DateOnly(2025, 4, 2), "Internet", "test-user-0001" },
                    { "test-billing-0005", 100.0, false, new DateOnly(2025, 4, 2), "Gas", "test-user-0001" },
                    { "test-billing-0006", 80.0, false, new DateOnly(2025, 4, 2), "Cable TV", "test-user-0001" },
                    { "test-billing-0007", 30.0, false, new DateOnly(2025, 4, 2), "Garbage Collection", "test-user-0001" },
                    { "test-billing-0008", 125.0, false, new DateOnly(2025, 4, 2), "Maintenance Fee", "test-user-0001" },
                    { "test-billing-0009", 60.0, false, new DateOnly(2025, 4, 2), "Security Fee", "test-user-0001" },
                    { "test-billing-0010", 500.0, false, new DateOnly(2025, 4, 2), "Property Tax", "test-user-0001" }
                });
        }
    }
}
