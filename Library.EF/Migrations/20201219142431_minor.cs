using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.EF.Migrations
{
    public partial class minor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "FilesMetaData");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "FilesMetaData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
