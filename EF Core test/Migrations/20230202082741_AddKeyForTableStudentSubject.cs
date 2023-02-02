using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_test.Migrations
{
    public partial class AddKeyForTableStudentSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentSubject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                columns: new[] { "SubjectId", "StudentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }
    }
}
