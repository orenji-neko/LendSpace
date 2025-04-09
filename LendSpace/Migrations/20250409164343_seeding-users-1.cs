using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingusers1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476eded3-03d0-4cea-a386-2f3f6fa4eeef", "AQAAAAIAAYagAAAAEI1vFiUGdIxwmjy3xr0EYtW8Ktqljf+mcwnMxxTZWTAWgp591guscClDVnOrYeNsPA==", "6e08f4c2-7152-4824-8534-b02f6e9bd14a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "test-admin-0001", 0, "123 Admin St.", "8264cc25-4bb7-4600-906c-590c6713424c", "admin@email.com", false, "John", "Doe", false, null, "A", "ADMIN@EMAIL.COM", "ADMIN@EMAIL.COM", null, null, false, "1304b637-b2b4-4020-a706-5faf54641da3", false, "admin@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-admin-0001", "test-admin-0001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-admin-0001", "test-admin-0001" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0d4b20-e8d8-431a-8acc-9c522c1a0bed", "AQAAAAIAAYagAAAAEDkMgU28HXV5Qsg7kRJ9rQPmp4d5nWeFtzFcWCbmBfROuRwUB2t95trPyrFHLkLgZA==", "6b235b60-83c5-4ef7-844c-b54f3dd154d3" });
        }
    }
}
