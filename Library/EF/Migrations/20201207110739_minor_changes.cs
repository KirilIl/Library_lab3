using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.EF.Migrations
{
    public partial class minor_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "PDF",
                table: "Files",
                newName: "FileInBytes");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Authors",
                newName: "FullName");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Files");

            migrationBuilder.RenameColumn(
                name: "FileInBytes",
                table: "Files",
                newName: "PDF");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
