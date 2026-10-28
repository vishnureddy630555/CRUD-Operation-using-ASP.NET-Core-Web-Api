
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.Infrastructure.Migrations
{
    public partial class CreateDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Create the department table
            migrationBuilder.CreateTable(
                name: "DepartmentDetails",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(
                        type: "int",
                        nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    DepartmentName = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_DepartmentDetails",
                        x => x.DepartmentId);
                });

            // 2. Insert a default department with ID 1
            migrationBuilder.InsertData(
                table: "DepartmentDetails",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[] { 1, "General" });

            // 3. Add the foreign key column.
            // Existing students receive DepartmentId = 1.
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "studentinformation",
                type: "int",
                nullable: false,
                defaultValue: 1);

            // 4. Create an index
            migrationBuilder.CreateIndex(
                name: "IX_studentinformation_DepartmentId",
                table: "studentinformation",
                column: "DepartmentId");

            // 5. Add the foreign key
            migrationBuilder.AddForeignKey(
                name: "FK_studentinformation_DepartmentDetails_DepartmentId",
                table: "studentinformation",
                column: "DepartmentId",
                principalTable: "DepartmentDetails",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentinformation_DepartmentDetails_DepartmentId",
                table: "studentinformation");

            migrationBuilder.DropIndex(
                name: "IX_studentinformation_DepartmentId",
                table: "studentinformation");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "studentinformation");

            migrationBuilder.DropTable(
                name: "DepartmentDetails");
        }
    }
}
