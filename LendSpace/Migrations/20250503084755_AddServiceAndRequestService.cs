using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceAndRequestService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPaid",
                table: "Billing",
                newName: "Status");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Pricing = table.Column<double>(type: "REAL", nullable: false),
                    Available = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    StartsAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndsAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceId = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0001",
                column: "Status",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceId",
                table: "Requests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Billing",
                newName: "IsPaid");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84a62242-2b71-409f-9a15-2668544b6cbb", new DateTime(2025, 4, 30, 20, 5, 20, 549, DateTimeKind.Utc).AddTicks(3498), "AQAAAAIAAYagAAAAEBdgyCW+mVYsVtSx3vKJ4W23OEYTMX/gBCd0zA1ZOM1j/GGGd3vV0T5I3tRE7zSAAw==", "ef667c34-a994-4464-bf7d-ece94be72cef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b05cbd3-bf5c-4bc4-995e-a10ef284c628", new DateTime(2025, 4, 30, 20, 5, 20, 627, DateTimeKind.Utc).AddTicks(2581), "AQAAAAIAAYagAAAAEDrhwz820H/RVtA70Vhjqp9Ic/wYMpRsVBRDx30IWVlK8c4hDyvMLt3G/2BKMYwROw==", "b176bed2-3714-414b-bf83-f0fc64a92db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d78be120-9534-46b0-b314-52063131e7a5", new DateTime(2025, 4, 30, 20, 5, 20, 392, DateTimeKind.Utc).AddTicks(5053), "AQAAAAIAAYagAAAAEIQjq1/cMqT0Hryr6THeUGFC+Euqc3g5VtkQyMeC4Z/HuFr/fllgkPwThTk2nwuIEg==", "bd0fa662-5186-4eed-8207-eaef98d8c2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae6f845e-1dd4-430a-9f0a-f9e0a992d665", new DateTime(2025, 4, 30, 20, 5, 20, 470, DateTimeKind.Utc).AddTicks(737), "AQAAAAIAAYagAAAAEP9WY2NApVlVIT7nVuwT5fHJHPPPetFs3Xxl1s+l9q2UZD3hgpwZeawNj0HrchWmdA==", "c17d0741-b679-4a13-8cd7-3a7e6449cb13" });

            migrationBuilder.UpdateData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0001",
                column: "IsPaid",
                value: false);
        }
    }
}
