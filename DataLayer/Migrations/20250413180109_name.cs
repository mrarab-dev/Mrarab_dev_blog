using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Articles",
                newName: "ArticleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ArticleComments",
                newName: "ArticleCommentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ArticleCategories",
                newName: "ArticleCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Articles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleCommentId",
                table: "ArticleComments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleCategoryId",
                table: "ArticleCategories",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
