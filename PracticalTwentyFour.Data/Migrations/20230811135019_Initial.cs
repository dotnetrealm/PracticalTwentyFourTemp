using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PracticalTwentyFour.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "Admin" },
                    { 3, "IT" },
                    { 4, "Sales" },
                    { 5, "On-site" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "EmailAddress", "IsDeleted", "JoiningDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Noopur@gmail.com", false, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noopur Bhavsar", 40000m },
                    { 2, 2, "shivam@gmail.com", false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shivam Patel", 50000m },
                    { 3, 3, "bhavin@gmail.com", false, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bhavin Kareliya", 60000m },
                    { 4, 3, "jil@gmail.com", false, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jil Patel", 60000m },
                    { 5, 4, "sales@gmail.com", false, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Manager", 30000m },
                    { 6, 5, "on-site@gmail.com", false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "On-site Developer", 35000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
