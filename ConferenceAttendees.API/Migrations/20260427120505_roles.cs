using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConferenceAttendees.API.Migrations
{
    /// <inheritdoc />
    public partial class roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0713d4d5-5560-4d36-b1ec-5bca0f52268a"), "Sales" },
                    { new Guid("14c05cd3-7064-46b4-9d61-d003942d4c05"), "Operations" },
                    { new Guid("825e19cc-89e1-4f7e-86a7-776efe3a403e"), "Supervisor" },
                    { new Guid("e42f1629-367f-42b6-b75c-36a391f7816e"), "Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumn: "Id",
                keyValue: new Guid("0713d4d5-5560-4d36-b1ec-5bca0f52268a"));

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumn: "Id",
                keyValue: new Guid("14c05cd3-7064-46b4-9d61-d003942d4c05"));

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumn: "Id",
                keyValue: new Guid("825e19cc-89e1-4f7e-86a7-776efe3a403e"));

            migrationBuilder.DeleteData(
                table: "JobRoles",
                keyColumn: "Id",
                keyValue: new Guid("e42f1629-367f-42b6-b75c-36a391f7816e"));
        }
    }
}
