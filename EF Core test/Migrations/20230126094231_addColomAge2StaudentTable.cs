using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_test.Migrations
{
    public partial class addColomAge2StaudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Student",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Student");
        }
    }
}
