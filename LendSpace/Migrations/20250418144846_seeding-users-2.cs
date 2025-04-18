using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class seedingusers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1242d51-ced4-4328-90a0-7d591b05c0fd", "8561c4d9-6709-4315-9b9b-02ed81962ab2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1402d0cc-d631-4ee0-a9db-cad5b7902b3a", "AQAAAAIAAYagAAAAEJMS7hs1j4trkzc0rZsCJz4AE2xrsD10p7lP47+aetu24fxSmOnX8yb17LjpymiT7A==", "711a930a-5049-4c1a-ad14-f2be7f384b8d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
