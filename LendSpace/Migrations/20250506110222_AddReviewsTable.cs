using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    FacilityId = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac17937-56ce-4e8b-bfde-a0f299fb0732", new DateTime(2025, 5, 6, 11, 2, 20, 550, DateTimeKind.Utc).AddTicks(1840), "AQAAAAIAAYagAAAAEGvrzSMqkmJxGl0SEYZzvY9j2JIr3OfE5+sJvPGRtME3K9NFj4yuhhOAcrsp79n7Qw==", "c5fe89be-65da-4d76-b8d7-2e2b2e2d547c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4cadc88-7c97-4193-8cdd-602320e3e20e", new DateTime(2025, 5, 6, 11, 2, 20, 620, DateTimeKind.Utc).AddTicks(1074), "AQAAAAIAAYagAAAAEPO6VYi9QpJZzckFnXx9Va1wMhcxcuiXmH5cGhJDjxezKErRgllfRoqUx+ADsBVMFw==", "e5624fa7-59d0-44a5-b001-65e7d3fb5070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d8b1404-0f9f-4dc4-872b-4133067c4345", new DateTime(2025, 5, 6, 11, 2, 20, 390, DateTimeKind.Utc).AddTicks(9996), "AQAAAAIAAYagAAAAEMYFJEa2WayEvFDHZm2pOEbvI8A72tdiBUkkqwfHdbeH98pIF0z0MGo6fOwFfLmmcw==", "e8cc75de-340f-4749-b428-28da1ce67bcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea0cdb9e-0c48-4aa7-84c0-b868b67a6fab", new DateTime(2025, 5, 6, 11, 2, 20, 481, DateTimeKind.Utc).AddTicks(4369), "AQAAAAIAAYagAAAAEFIrk3fM35NIsn1kfpEUmDw0pRWnnWdI3YQ5Yzv/ZgAcfS21n+hHB4rWtAqHV4aoJw==", "80b2e8e7-805b-4445-8b63-9fd7e1b0bc86" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: "test-notification-0001",
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "FacilityId", "Rating", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "test-review-0001", "Excellent facility! The swimming pool was clean and well-maintained.", new DateTime(2025, 5, 1, 19, 2, 20, 701, DateTimeKind.Local).AddTicks(4455), "test-facility-0001", 5, null, "test-user-0001" },
                    { "test-review-0002", "Great place to relax with family. Could use more lounge chairs.", new DateTime(2025, 5, 4, 19, 2, 20, 704, DateTimeKind.Local).AddTicks(5819), "test-facility-0001", 4, null, "test-user-0002" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FacilityId",
                table: "Reviews",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

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
                table: "Notifications",
                keyColumn: "Id",
                keyValue: "test-notification-0001",
                column: "CreatedAt",
                value: new DateOnly(2025, 4, 6));
        }
    }
}
