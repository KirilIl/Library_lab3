using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.EF.Migrations
{
    public partial class FileMetaDataNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "FilesMetaData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilesMetaData",
                table: "FilesMetaData",
                columns: new[] { "BookId", "Type" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FilesMetaData",
                table: "FilesMetaData");

            migrationBuilder.RenameTable(
                name: "FilesMetaData",
                newName: "Files");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                columns: new[] { "BookId", "Type" });
        }
    }
}
