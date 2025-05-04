using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class GenerateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a478614-6c6f-49e8-9395-4b7ee7a8ff18", new DateTime(2025, 5, 4, 5, 55, 36, 702, DateTimeKind.Utc).AddTicks(4699), "AQAAAAIAAYagAAAAECTj64Hwc3bo5d/azjrAK2vcNjvjuOBdHHH0XSMRC0XWhXhffZEqpaKOpQcPCoKndg==", "ead719f6-927f-448e-98b4-1dbbf9fa29ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9093631d-510c-48fd-ba47-fc2c2b06189b", new DateTime(2025, 5, 4, 5, 55, 36, 779, DateTimeKind.Utc).AddTicks(4682), "AQAAAAIAAYagAAAAEIbGMh9Kj4Zh30vx9650SoktcaAc3FdH2Pm6pLLAu8MiQge00RKdHqyHaMLM9AGc9w==", "522e2772-e24f-499c-acce-3ef6fcf49c31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4247f395-7f90-48c3-a023-84a9a7bc5fba", new DateTime(2025, 5, 4, 5, 55, 36, 552, DateTimeKind.Utc).AddTicks(4139), "AQAAAAIAAYagAAAAEBmr2ArZIYr8RDdol1lt3uQ7AFuKmrHM4wHp+A+W4q/3ANM2FlpdV/xO6TVCmw6wGA==", "349f73e2-4254-4d48-9b31-eca25697ae70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff51e813-458e-4593-bd0a-a94728565260", new DateTime(2025, 5, 4, 5, 55, 36, 637, DateTimeKind.Utc).AddTicks(281), "AQAAAAIAAYagAAAAEF0Q1NJx5D7eIUPuWSz8HAhBtYbwAtmfKhD0FV8tt8JOm0AZlyL2Yl1cTax7qKDxyA==", "32f21296-bf41-4dff-9460-4ac9ce68d528" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "824448e5-0755-4370-ab2e-2cea9c17b4f9", new DateTime(2025, 5, 3, 8, 47, 54, 670, DateTimeKind.Utc).AddTicks(1241), "AQAAAAIAAYagAAAAEEr338kxk9676R6yrznytIWnQsWO7Rq9F5BvkCCyxRF/xkMpSMD67W6lYF+IrdaNsg==", "8324d250-a0ae-4145-bb35-905d8deb84b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eff0f42-b31f-4159-8ac0-e457ff03a02e", new DateTime(2025, 5, 3, 8, 47, 54, 713, DateTimeKind.Utc).AddTicks(9305), "AQAAAAIAAYagAAAAEPVx/iy3RTSAcVv4vbruP3gXXvGkfOv/ea2pIVgd37hpp2DVfaogZuUMBRNX8Sz/RQ==", "cc969a4d-32de-4479-8990-cd75a645af9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adeb9886-59bc-48e3-b1a0-0f98197f0072", new DateTime(2025, 5, 3, 8, 47, 54, 575, DateTimeKind.Utc).AddTicks(8154), "AQAAAAIAAYagAAAAEHDQdPMK2WLo6Dyy/Idxj3oYYkzEzlQcFokopgAUIg8WN6ndsOktZ3rM7Bg+bqkApQ==", "dfffa42d-3066-4227-ba6a-c2c586935ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c73fc66-b15b-4a64-8253-19322e4bd15f", new DateTime(2025, 5, 3, 8, 47, 54, 624, DateTimeKind.Utc).AddTicks(9094), "AQAAAAIAAYagAAAAEH+ksXJye3OubAPczofI1Fl/rb00Xnmp55Fgs6XpkCfTOooCJ6a77grhpvCaLhZfwA==", "ef9a6824-ce2d-4d5b-8168-cce50334dd5a" });
        }
    }
}
