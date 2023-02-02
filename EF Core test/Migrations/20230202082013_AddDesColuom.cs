using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_test.Migrations
{
    public partial class AddDesColuom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Student");
        }
    }
}
