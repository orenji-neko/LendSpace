using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddCommunityPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f201d1f2-fcac-4b71-a30c-987402412ff9", "AQAAAAIAAYagAAAAEGcEDJAnC++fdHe731f+S1njSnudF9c1w7gEP5yGrdUiRYlqS8r9sYISsCVgikcHKg==", "bf2e6961-c0b1-41e4-bba5-c017fddf2768" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0c692a1-57a0-4267-85ad-beebfc774d00", "AQAAAAIAAYagAAAAEEDEQzqoK6LVVt75QHRoXS9TjR9Icty7UP6fl6wd2Yw8ZTaxEj9Woqh+8FsU27l0Bg==", "85b3eb0b-e70d-42b1-a505-076f92509c45" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "357bcb31-b6e5-4ff3-8731-6eb1d9ba4415", "AQAAAAIAAYagAAAAEGIIhKtgguA1sB++GaWUzkoTX1QYK5tENHsYuH1NDEldTHa4EskUpmp9jYVm/DSVBg==", "61c0b52f-ca7e-40dc-be0c-9f6cc64e4f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21efd07f-ad97-41d5-97d3-f307a2d58911", "AQAAAAIAAYagAAAAEJxu5Pi5ItqHxUAVfg2Hor6YZY243RRt2+ytApN8Fj/M9NmcHHLEWLVwsafEW8dEgQ==", "ad243eb2-7420-473f-a927-b22e8b2d2582" });
        }
    }
}
