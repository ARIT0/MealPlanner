using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class incrementedPKS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Tags_TagsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TagsId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagsId",
                table: "Recipes",
                column: "TagsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Tags_TagsId",
                table: "Recipes",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Tags_TagsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TagsId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagsId",
                table: "Recipes",
                column: "TagId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Tags_TagsId",
                table: "Recipes",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
