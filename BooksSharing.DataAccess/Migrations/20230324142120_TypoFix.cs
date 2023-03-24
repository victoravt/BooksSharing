using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksSharing.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TypoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksToGenresRelationships_Generes_GeneresId",
                table: "BooksToGenresRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generes",
                table: "Generes");

            migrationBuilder.RenameTable(
                name: "Generes",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "GeneresId",
                table: "BooksToGenresRelationships",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksToGenresRelationships_GeneresId",
                table: "BooksToGenresRelationships",
                newName: "IX_BooksToGenresRelationships_GenresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToGenresRelationships_Genres_GenresId",
                table: "BooksToGenresRelationships",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksToGenresRelationships_Genres_GenresId",
                table: "BooksToGenresRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Generes");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "BooksToGenresRelationships",
                newName: "GeneresId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksToGenresRelationships_GenresId",
                table: "BooksToGenresRelationships",
                newName: "IX_BooksToGenresRelationships_GeneresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generes",
                table: "Generes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToGenresRelationships_Generes_GeneresId",
                table: "BooksToGenresRelationships",
                column: "GeneresId",
                principalTable: "Generes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
