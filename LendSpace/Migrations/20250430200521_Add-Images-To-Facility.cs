using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToFacility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Facility",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84a62242-2b71-409f-9a15-2668544b6cbb", new DateTime(2025, 4, 30, 20, 5, 20, 549, DateTimeKind.Utc).AddTicks(3498), "AQAAAAIAAYagAAAAEBdgyCW+mVYsVtSx3vKJ4W23OEYTMX/gBCd0zA1ZOM1j/GGGd3vV0T5I3tRE7zSAAw==", "ef667c34-a994-4464-bf7d-ece94be72cef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b05cbd3-bf5c-4bc4-995e-a10ef284c628", new DateTime(2025, 4, 30, 20, 5, 20, 627, DateTimeKind.Utc).AddTicks(2581), "AQAAAAIAAYagAAAAEDrhwz820H/RVtA70Vhjqp9Ic/wYMpRsVBRDx30IWVlK8c4hDyvMLt3G/2BKMYwROw==", "b176bed2-3714-414b-bf83-f0fc64a92db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d78be120-9534-46b0-b314-52063131e7a5", new DateTime(2025, 4, 30, 20, 5, 20, 392, DateTimeKind.Utc).AddTicks(5053), "AQAAAAIAAYagAAAAEIQjq1/cMqT0Hryr6THeUGFC+Euqc3g5VtkQyMeC4Z/HuFr/fllgkPwThTk2nwuIEg==", "bd0fa662-5186-4eed-8207-eaef98d8c2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae6f845e-1dd4-430a-9f0a-f9e0a992d665", new DateTime(2025, 4, 30, 20, 5, 20, 470, DateTimeKind.Utc).AddTicks(737), "AQAAAAIAAYagAAAAEP9WY2NApVlVIT7nVuwT5fHJHPPPetFs3Xxl1s+l9q2UZD3hgpwZeawNj0HrchWmdA==", "c17d0741-b679-4a13-8cd7-3a7e6449cb13" });

            migrationBuilder.UpdateData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                column: "ImagePath",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Facility");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa80c21e-4b16-4399-a68c-d4fa85522fd2", new DateTime(2025, 4, 30, 18, 3, 30, 924, DateTimeKind.Utc).AddTicks(6605), "AQAAAAIAAYagAAAAEPsEbzZ31TsAwxNMIqymfRMHq/RSYqInNTehX5iTbCwTLIUM7b4Xk8fULq3KWoDJ3Q==", "5f160d6b-d566-4520-8510-d62b22f861e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-staff-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "346a9cca-d49f-44a2-b81b-862745ae011d", new DateTime(2025, 4, 30, 18, 3, 30, 969, DateTimeKind.Utc).AddTicks(9423), "AQAAAAIAAYagAAAAEIy8qQpR2N7Axu1GzeHr+04wi1CtaC+cYoVpXaFAmLWK/j5G+RadmnkBYlUlakW+fA==", "6d35a731-e525-4b94-984b-9f6cb414349d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f1ff4a-ddb7-48ee-87a7-fd656830998b", new DateTime(2025, 4, 30, 18, 3, 30, 831, DateTimeKind.Utc).AddTicks(2936), "AQAAAAIAAYagAAAAEEofsGm8kXHMyz7sFAjjH4j/xc5EgU/jL90M6MQvNJanS0O+5kHvOEP1vJS2+jK8WQ==", "f5f99b33-6853-4d77-9cd3-a0513924fc2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a42c96e3-ad30-4a77-859f-5a64aa5e30af", new DateTime(2025, 4, 30, 18, 3, 30, 877, DateTimeKind.Utc).AddTicks(5585), "AQAAAAIAAYagAAAAECNmSYa0UUljRdUu5QruCqsHfJ6jMc+eVH01EcWpmFzdqZep3nGcS7B8bVKQKLGFzg==", "3ec677d3-66c1-4a73-8678-5f9f62b912b4" });
        }
    }
}
