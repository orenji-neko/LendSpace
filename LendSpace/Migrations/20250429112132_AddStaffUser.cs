using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddStaffUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "role-staff-0001", null, "Staff", "STAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7aa67b-69ac-4457-b8ce-c1c118d119d9", new DateTime(2025, 4, 29, 11, 21, 30, 298, DateTimeKind.Utc).AddTicks(1257), "AQAAAAIAAYagAAAAEFPbiZ7B2cHKkTSflh4CEeU+3s9B9U40fRlB90TpzwEL1C6NYdOtL537zMCH8L9PlA==", "17ffd297-ba17-4f05-906c-e10e398de2aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9476fcc0-6102-4644-9e6b-a23c25495fe8", new DateTime(2025, 4, 29, 11, 21, 30, 92, DateTimeKind.Utc).AddTicks(6496), "AQAAAAIAAYagAAAAEA3/1VG2vKr/DqQEW33FjgtJHMZHejMFEWrkdTNyhg+S0RLEbuhXLRJH6ykHJ5ygPQ==", "2ff8123e-4b4f-4544-b921-a74f4370f430" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "test-staff-0001", 0, "123 Staff St.", "f23c48dc-ebf2-4ea0-956d-802adc22f789", new DateTime(2025, 4, 29, 11, 21, 30, 409, DateTimeKind.Utc).AddTicks(4381), "staff@email.com", false, "Jane", "Smith", false, null, "B", "STAFF@EMAIL.COM", "STAFF@EMAIL.COM", "AQAAAAIAAYagAAAAEHoR6MhD/IniTCmsnIgCfKB+cqZb4ayiwTRnafvxn1fD6NYSaN4RvBOfcGl1NcXbKA==", null, false, null, "24cdce89-f80f-49c9-ae7d-9b2ba3cfc6be", false, "staff@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-staff-0001", "test-staff-0001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-staff-0001", "test-staff-0001" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-staff-0001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "384ee4fa-cc16-40cc-a9b2-93daeaa6a5b7", new DateTime(2025, 4, 29, 5, 33, 52, 737, DateTimeKind.Utc).AddTicks(9452), "AQAAAAIAAYagAAAAEHtHZqPDfyjcloF4/AbBoqhFKE/s99TZ8kjXaZixABByBsIO/sJDABe8q6/mk8/5Yw==", "366f1fbf-25ac-4fb9-bc47-f76b2cae8437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376faf40-379e-4372-a78d-dfca168fb00a", new DateTime(2025, 4, 29, 5, 33, 52, 614, DateTimeKind.Utc).AddTicks(7404), "AQAAAAIAAYagAAAAEECxnqKgqnbcLvv5WfNOqZrhbIc9dTNabGcHTpDAEYLL2Ie6wjbdNkL6JJRIVVJjVA==", "c1574254-eb9a-4abd-9141-96e6965bbeda" });
        }
    }
}
