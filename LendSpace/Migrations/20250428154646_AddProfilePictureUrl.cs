using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "7ec3d018-ba2c-4820-ad01-3e1283183662", "AQAAAAIAAYagAAAAEH94515x7p6x5zkURYiPljA09KQQoCBXzQXj91BOud6qu4Hy8AATCOqTH7xK+jpipQ==", null, "94ba4d31-d0b5-45d4-8374-96607ff50b3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "d833f5c9-2f47-4307-b3ee-35bdad7a2ea0", "AQAAAAIAAYagAAAAECQXNdyPBDtjz+xD4PkNancOAl20P7tfsQXlK48DIbcgfwJBu1IGmclVH1kGTnGfzw==", null, "10f25645-3352-4809-ad14-53ce6445c5e6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3afec1a3-845e-4326-8a1d-d5e7d5767cd9", "AQAAAAIAAYagAAAAEOv/P9+zKEBShQuJvyO9CoX2f201+M4ShTHI5SxMYfon/lH7T21D2KtkPeqzU7KKwA==", "2cd50933-3dca-4c06-8514-a08750e45cbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e66d7474-3112-4f0d-9f71-5b5e25d07d76", "AQAAAAIAAYagAAAAEKOjjZb+6V/k5jp2RVvQihPxdouHeCCGIY2Y9l63gHLmNkrZO1Ki8/YdlBitLf2i1g==", "8dba6591-774e-4f62-a7fc-edb176e477f2" });
        }
    }
}
