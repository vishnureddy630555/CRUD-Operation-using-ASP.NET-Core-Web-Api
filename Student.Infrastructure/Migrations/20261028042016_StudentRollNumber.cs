using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StudentRollNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "StudentRollNumber",
                table: "studentinformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentRollNumber",
                table: "studentinformation");
        }
    }
}
