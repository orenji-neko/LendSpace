using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57f975fd-9f00-4b4b-b731-b662ea28cea4", new DateTime(2025, 4, 29, 16, 12, 41, 422, DateTimeKind.Utc).AddTicks(6345), "AQAAAAIAAYagAAAAEIdyTV2sC4BqlA09JqbI/C5c7l2G9ViBrwMNfK/btjHve0JyoaiqfX6rgrk9GhiUTg==", "b49b1726-b799-46c4-a3dd-a298e9abe56a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedDate", "Email", "FirstName", "LastName", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Cebu City", "42ecf4b4-a8e9-483c-a84b-085c88696adc", new DateTime(2025, 4, 29, 16, 12, 41, 315, DateTimeKind.Utc).AddTicks(9665), "user1@email.com", "Ian John", "Dal", "L", "USER1@EMAIL.COM", "USER1@EMAIL.COM", "AQAAAAIAAYagAAAAEHZU1eEPTpb/TIwRxpB1u13O1E7ZT/tsjBt60R+wOiaejdXq9S650Fzuh7fJiRvDDQ==", "54433ab3-81b1-4af8-abbd-68bb1e485b97", "user1@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "test-user-0002", 0, "Basey, Samar", "fb26ddd5-9073-4693-a185-9c7e400b76dd", new DateTime(2025, 4, 29, 16, 12, 41, 369, DateTimeKind.Utc).AddTicks(1303), "user2@email.com", false, "Christian", "Yancha", false, null, "D", "USER2@EMAIL.COM", "USER2@EMAIL.COM", "AQAAAAIAAYagAAAAEF9WWZktHdu2NQAp4D8cSTgXJMflNjlgTIJdKJ+ra4sBhkjqrgCXrYDA37MG8oR+GQ==", null, false, null, "2fe51114-d28c-417a-b3db-84335163d2ee", false, "user2@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-user-0001", "test-user-0002" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-user-0001", "test-user-0002" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f29e8615-b409-4d70-9e4a-bcedd813d3cc", new DateTime(2025, 4, 29, 15, 51, 54, 231, DateTimeKind.Utc).AddTicks(3124), "AQAAAAIAAYagAAAAECswnV0gvKx1aBkEUt+aUQm3ddbAH4/jv0n2kU5LVWrzjBkJ5m4VThfg5xO9YgL5Jw==", "44249fe2-8db8-4bde-bac3-dc47f7603b46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedDate", "Email", "FirstName", "LastName", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "123 User St.", "a6540282-ee77-49de-8eb6-f3c249dfe807", new DateTime(2025, 4, 29, 15, 51, 54, 184, DateTimeKind.Utc).AddTicks(7814), "user@email.com", "John", "Doe", "A", "USER@EMAIL.COM", "USER@EMAIL.COM", "AQAAAAIAAYagAAAAEKZbBm77NbLUKfDf1dI1WN+kLBXDmP4ZL7C9rrD5nam5DGCBKIYD3uwC9p5SLQY1PQ==", "0c4de941-2cec-4819-b694-4b47a03479e8", "user@email.com" });
        }
    }
}
