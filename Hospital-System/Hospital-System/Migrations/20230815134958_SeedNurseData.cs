using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class SeedNurseData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Internal Medicine" },
                    { 2, "Surgery" }
                });

            migrationBuilder.InsertData(
                table: "Nurses",
                columns: new[] { "Id", "ContactNumber", "DepartmentId", "FirstName", "Gender", "LastName", "shift" },
                values: new object[,]
                {
                    { 1, "123-456-7890", 1, "Moh ", "Male", "Ahmad", 0 },
                    { 2, "987-654-3210", 2, "Jane", "Female", "JG", 2 },
                    { 3, "555-555-5555", 1, "fname", "Male", "lname", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
