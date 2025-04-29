using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddCommunityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fa0417-3a3c-4e26-bd2d-0d7dfd11dcbb", "AQAAAAIAAYagAAAAEJtHVgrGVB7rHTmU51TUpT+67mZHh0fqwcKN4n3t9tIkO5cfuQ/mDof27udW314YrA==", "18c44b13-5572-4b53-a63b-966b6b2efba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a575169c-3359-4686-9c07-3c1e3e6f34c8", "AQAAAAIAAYagAAAAEFk+r17wIUgB7mhaNx6Or4zJHMZSF0iGuBU1Pn6GMS/PiEv6rEG7Fah/ulZmBfTD2g==", "edae971c-82b3-4d89-9e91-fd323be2f19f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
