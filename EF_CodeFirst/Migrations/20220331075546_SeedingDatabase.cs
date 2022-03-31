using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 1, new DateTime(1986, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, "Petra Ivić", 55.0 });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 2, new DateTime(1999, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.85m, "Ivan Franjić", 85.0 });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeId", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, "Odličan", "Matematika", 1 },
                    { 2, "Vrlo dobar", "Povijest", 1 },
                    { 3, "Odličan", "Fizika", 1 },
                    { 4, "Dobar", "Matematika", 2 },
                    { 5, "Vrlo dobar", "Fizika", 2 },
                    { 6, "Odličan", "Hrvatski", 2 },
                    { 7, "Odličan", "Kemija", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2);
        }
    }
}
