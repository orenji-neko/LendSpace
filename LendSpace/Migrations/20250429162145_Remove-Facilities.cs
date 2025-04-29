using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LendSpace.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFacilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0002");

            migrationBuilder.DeleteData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0003");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "993d01ce-adef-4e80-9869-489625214e83", new DateTime(2025, 4, 29, 16, 21, 44, 830, DateTimeKind.Utc).AddTicks(7818), "AQAAAAIAAYagAAAAEIbF/Iuv+yeNEfPwCpU5InuWxV0dLNek1yxYOL/z+EYq4cEnZ/N9lBybXRncTMSsLQ==", "4a7f7456-0a19-476d-bd76-4105d8b9213c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79f9f28a-aa26-4e68-98a5-c367580ecce2", new DateTime(2025, 4, 29, 16, 21, 44, 725, DateTimeKind.Utc).AddTicks(2211), "AQAAAAIAAYagAAAAEJjOZGzieNbnX72SsWILdv/+576DBrkfIId0V3UIKJEpZV4uSsGww1AtAofbE071VQ==", "60c4061e-473f-4583-bef1-08b2aa9f97d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0bfb57a-3598-44ef-9969-fd135189fa93", new DateTime(2025, 4, 29, 16, 21, 44, 777, DateTimeKind.Utc).AddTicks(7811), "AQAAAAIAAYagAAAAEAzOPy5OgmNHG7NVQgxIlCRSHQAMnSQwvtodXU62ss64HS6aTPD6/59rXDm+HWToHw==", "18aa2a0c-a7f3-4bca-bafa-445321db6deb" });

            migrationBuilder.UpdateData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Biringan City, Samar", "A big tub, with water!", "Swimming Pool" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ecf4b4-a8e9-483c-a84b-085c88696adc", new DateTime(2025, 4, 29, 16, 12, 41, 315, DateTimeKind.Utc).AddTicks(9665), "AQAAAAIAAYagAAAAEHZU1eEPTpb/TIwRxpB1u13O1E7ZT/tsjBt60R+wOiaejdXq9S650Fzuh7fJiRvDDQ==", "54433ab3-81b1-4af8-abbd-68bb1e485b97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0002",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb26ddd5-9073-4693-a185-9c7e400b76dd", new DateTime(2025, 4, 29, 16, 12, 41, 369, DateTimeKind.Utc).AddTicks(1303), "AQAAAAIAAYagAAAAEF9WWZktHdu2NQAp4D8cSTgXJMflNjlgTIJdKJ+ra4sBhkjqrgCXrYDA37MG8oR+GQ==", "2fe51114-d28c-417a-b3db-84335163d2ee" });

            migrationBuilder.UpdateData(
                table: "Facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "Id", "Address", "Available", "Description", "Name" },
                values: new object[,]
                {
                    { "test-facility-0002", "Somewhere, i don't really know.", true, "Tell me about this facility", "Facility Name" },
                    { "test-facility-0003", "Somewhere, i don't really know.", true, "Tell me about this facility", "Facility Name" }
                });
        }
    }
}
