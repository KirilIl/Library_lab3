using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.EF.Migrations
{
    public partial class minorChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Files",
                newName: "Path");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Files",
                newName: "Name");
        }
    }
}
