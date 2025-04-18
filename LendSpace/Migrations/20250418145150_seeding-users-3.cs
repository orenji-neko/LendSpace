using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingusers3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1242d51-ced4-4328-90a0-7d591b05c0fd", null, "8561c4d9-6709-4315-9b9b-02ed81962ab2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1402d0cc-d631-4ee0-a9db-cad5b7902b3a", "AQAAAAIAAYagAAAAEJMS7hs1j4trkzc0rZsCJz4AE2xrsD10p7lP47+aetu24fxSmOnX8yb17LjpymiT7A==", "711a930a-5049-4c1a-ad14-f2be7f384b8d" });
        }
    }
}
