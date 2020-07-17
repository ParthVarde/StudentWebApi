using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class SampleDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentDob", "StudentMarks", "StudentName" },
                values: new object[] { 1, new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, "Dharmik" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);
        }
    }
}
