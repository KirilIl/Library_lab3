using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.EF.Migrations
{
    public partial class quoteandFileChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteAuthor",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Quotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_BookId",
                table: "Quotes",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Books_BookId",
                table: "Quotes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Books_BookId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_BookId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Quotes");

            migrationBuilder.AddColumn<string>(
                name: "QuoteAuthor",
                table: "Quotes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
