using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class ModifyEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartedAt",
                table: "Events",
                newName: "StartsAt");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndsAt",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "223f8bdc-5919-4f9f-84ce-d1125d72c136", new DateTime(2025, 5, 4, 15, 0, 38, 944, DateTimeKind.Utc).AddTicks(2602), "AQAAAAIAAYagAAAAEMyvQWq3GsV3RHu4YIqe5Sp2NznwsCfwSaBf/40zyRGyZBhI3e840He7DqwArJorkg==", "468933b3-aed7-463d-88f9-c03e74311904" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb8b751e-1471-4810-b7b7-051527b3db27", new DateTime(2025, 5, 4, 15, 0, 39, 25, DateTimeKind.Utc).AddTicks(9138), "AQAAAAIAAYagAAAAEGiCsQ4a06KPfNv+ii1yuwJCYyUL3Mc4BFNZRAfzfVrqOOdWnZvCZ9ocrKSHLVFSYQ==", "25e864bf-51ec-48a3-9abb-6e90e0ef95ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc74d19-d9ef-42d2-b43b-389450f966de", new DateTime(2025, 5, 4, 15, 0, 38, 780, DateTimeKind.Utc).AddTicks(7251), "AQAAAAIAAYagAAAAEMrf2fdw4O6YbZymb4nwNrvOTneCKEwoqfJ9wWWm+fdnX2zCElRh4WLLBEjcemoF6A==", "a73bec0a-6ad0-465c-acab-3e9bc6ac56c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45ee12a8-1152-438c-979c-afe6eb5b3947", new DateTime(2025, 5, 4, 15, 0, 38, 863, DateTimeKind.Utc).AddTicks(1047), "AQAAAAIAAYagAAAAEHXT40+9lA/RIPYFilyY8pKhBMubBx4RRxSbHJ661hlnUE03Xl0fs4vrOz025jJ0Nw==", "5929ca84-defe-47a2-a288-081942233280" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0001",
                columns: new[] { "EndsAt", "Status" },
                values: new object[] { new DateOnly(2025, 4, 6), 0 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0002",
                columns: new[] { "EndsAt", "StartsAt", "Status" },
                values: new object[] { new DateOnly(2025, 4, 6), new DateOnly(2025, 4, 6), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndsAt",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartsAt",
                table: "Events",
                newName: "StartedAt");

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

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "test-event-0002",
                column: "StartedAt",
                value: new DateOnly(2025, 4, 15));
        }
    }
}
