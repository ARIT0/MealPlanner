using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class AddedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngQuant_Ingredients_IngIdfk",
                table: "IngQuant");

            migrationBuilder.DropForeignKey(
                name: "FK_IngQuant_Recipes_RecIdfk",
                table: "IngQuant");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Tags_TagIdfk",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TagIdfk",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_IngQuant_IngIdfk",
                table: "IngQuant");

            migrationBuilder.DropIndex(
                name: "IX_IngQuant_RecIdfk",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "TagIdfk",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngIdfk",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "RecIdfk",
                table: "IngQuant");

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecId",
                table: "Instructions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "InstId",
                table: "Instructions",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngQuantId",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngId",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions",
                column: "InstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant",
                column: "IngQuantId");

            migrationBuilder.CreateTable(
                name: "NewRecipeVM",
                columns: table => new
                {
                    RecId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecName = table.Column<string>(nullable: false),
                    IngName = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UM = table.Column<string>(nullable: false),
                    StepOrder = table.Column<int>(nullable: false),
                    Instruct = table.Column<string>(nullable: false),
                    TagName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewRecipeVM", x => x.RecId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewRecipeVM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "TagName",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "InstId",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "IngQuantId",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "IngId",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "RecId",
                table: "IngQuant");

            migrationBuilder.AddColumn<int>(
                name: "TagIdfk",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecId",
                table: "Instructions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngIdfk",
                table: "IngQuant",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecIdfk",
                table: "IngQuant",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions",
                column: "RecId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagIdfk",
                table: "Recipes",
                column: "TagIdfk");

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_IngIdfk",
                table: "IngQuant",
                column: "IngIdfk");

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_RecIdfk",
                table: "IngQuant",
                column: "RecIdfk");

            migrationBuilder.AddForeignKey(
                name: "FK_IngQuant_Ingredients_IngIdfk",
                table: "IngQuant",
                column: "IngIdfk",
                principalTable: "Ingredients",
                principalColumn: "IngId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngQuant_Recipes_RecIdfk",
                table: "IngQuant",
                column: "RecIdfk",
                principalTable: "Recipes",
                principalColumn: "RecId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Tags_TagIdfk",
                table: "Recipes",
                column: "TagIdfk",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
