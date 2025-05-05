using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GuestCount",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewedAt",
                table: "Reservations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedById",
                table: "Reservations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffNotes",
                table: "Reservations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    UserModelId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4683dce9-5fb9-4919-80e7-6f4ce8e5dddc", new DateTime(2025, 5, 4, 12, 32, 11, 138, DateTimeKind.Utc).AddTicks(7214), "AQAAAAIAAYagAAAAEILyKK/eKQfDc9d6zOlSHQVBAjk0NdK9TL1BsYxDc2ZO5BVHJoGQk0IfvPLH4DkMPw==", "826ce03a-e6f5-449e-926b-5f5e93010c3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "691a3ab4-9591-4377-acc7-bf23eb38737f", new DateTime(2025, 5, 4, 12, 32, 11, 215, DateTimeKind.Utc).AddTicks(4553), "AQAAAAIAAYagAAAAEAKf/ri3U8kKbM7v41xBrfdrIlzuwEM0nqztyMXdd6XtBoqkniK+ItSI1gR4CVnC3A==", "3fcf5f76-449b-44e2-be0c-b70a28d31dd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f62256e-1d1c-4d4b-860c-f7d8dd6c9a4e", new DateTime(2025, 5, 4, 12, 32, 10, 915, DateTimeKind.Utc).AddTicks(7207), "AQAAAAIAAYagAAAAECtSh0+YT+XZjsJaHNuUVxd5b5Xy23kqismgPMlCcbIzl9MYAFljMzRbtsPfArPkMQ==", "4683e0af-a132-4af0-8632-4a8212f096e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "881b50a2-d21f-4477-8f0e-8c0b9f654803", new DateTime(2025, 5, 4, 12, 32, 11, 53, DateTimeKind.Utc).AddTicks(7261), "AQAAAAIAAYagAAAAELcujlQ3AxN+UXXBdnrnVGa5zsdTc8IilRDXziKkWoiy+6wNQou7B6DMurUPy6i1fg==", "5c6ffffb-cd2b-4b59-afda-44a30f203b53" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsRead", "Link", "Message", "Title", "Type", "UserId", "UserModelId" },
                values: new object[] { "test-notification-0001", new DateOnly(2025, 4, 6), false, "/dashboard", "Thank you for joining our community!", "Welcome to LendSpace", 5, "test-user-0001", null });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReviewedById",
                table: "Reservations",
                column: "ReviewedById");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserModelId",
                table: "Notifications",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_ReviewedById",
                table: "Reservations",
                column: "ReviewedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_ReviewedById",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReviewedById",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "GuestCount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReviewedAt",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReviewedById",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StaffNotes",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Reservations");

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
    }
}
