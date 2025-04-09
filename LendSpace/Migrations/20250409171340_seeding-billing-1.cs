using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingbilling1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcec9c5f-31e2-4731-a3c5-1f820e7503ff", "154145f6-5c92-4043-8fab-9010f9f1bd04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adcfc754-905f-476f-837a-e9c5c388b904", "AQAAAAIAAYagAAAAENA4WPHPxwmFv74iwJVFO0J/6LQmg6209myvwLJeWhmLDwl74iJAKN+HppohTZGFyw==", "3975a99e-4e9d-414c-86db-986ca7184868" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "Amount", "IsPaid", "IssuedAt", "Name", "UserId" },
                values: new object[,]
                {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8264cc25-4bb7-4600-906c-590c6713424c", "1304b637-b2b4-4020-a706-5faf54641da3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476eded3-03d0-4cea-a386-2f3f6fa4eeef", "AQAAAAIAAYagAAAAEI1vFiUGdIxwmjy3xr0EYtW8Ktqljf+mcwnMxxTZWTAWgp591guscClDVnOrYeNsPA==", "6e08f4c2-7152-4824-8534-b02f6e9bd14a" });
        }
    }
}
