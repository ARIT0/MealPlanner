using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class changesToPKS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewRecipeVM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserRegistration");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "RecId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagName",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "InstId",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "RecId",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "IngId",
                table: "Ingredients");

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
                name: "Id",
                table: "UserRegistration",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Tags",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Recipes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructions",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RecipeClassId",
                table: "Instructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngredientsClassId",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeClassId",
                table: "IngQuant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeClassId1",
                table: "IngQuant",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagId",
                table: "Recipes",
                column: "TagId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_RecipeClassId",
                table: "Instructions",
                column: "RecipeClassId");

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_IngredientsClassId",
                table: "IngQuant",
                column: "IngredientsClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_RecipeClassId",
                table: "IngQuant",
                column: "RecipeClassId");

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_RecipeClassId1",
                table: "IngQuant",
                column: "RecipeClassId1");

            migrationBuilder.AddForeignKey(
                name: "FK_IngQuant_Ingredients_IngredientsClassId",
                table: "IngQuant",
                column: "IngredientsClassId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngQuant_Recipes_RecipeClassId",
                table: "IngQuant",
                column: "RecipeClassId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngQuant_Recipes_RecipeClassId1",
                table: "IngQuant",
                column: "RecipeClassId1",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_Recipes_RecipeClassId",
                table: "Instructions",
                column: "RecipeClassId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Tags_TagId",
                table: "Recipes",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_UserRegistration_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "UserRegistration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngQuant_Ingredients_IngredientsClassId",
                table: "IngQuant");

            migrationBuilder.DropForeignKey(
                name: "FK_IngQuant_Recipes_RecipeClassId",
                table: "IngQuant");

            migrationBuilder.DropForeignKey(
                name: "FK_IngQuant_Recipes_RecipeClassId1",
                table: "IngQuant");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_Recipes_RecipeClassId",
                table: "Instructions");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Tags_TagId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_UserRegistration_UserId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TagId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_Instructions_RecipeClassId",
                table: "Instructions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant");

            migrationBuilder.DropIndex(
                name: "IX_IngQuant_IngredientsClassId",
                table: "IngQuant");

            migrationBuilder.DropIndex(
                name: "IX_IngQuant_RecipeClassId",
                table: "IngQuant");

            migrationBuilder.DropIndex(
                name: "IX_IngQuant_RecipeClassId1",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRegistration");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "RecipeClassId",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "IngredientsClassId",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "RecipeClassId",
                table: "IngQuant");

            migrationBuilder.DropColumn(
                name: "RecipeClassId1",
                table: "IngQuant");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstId",
                table: "Instructions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "Instructions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngQuantId",
                table: "IngQuant",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IngId",
                table: "IngQuant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "IngQuant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "RecId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructions",
                table: "Instructions",
                column: "InstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "IngId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngQuant",
                table: "IngQuant",
                column: "IngQuantId");

            migrationBuilder.CreateTable(
                name: "NewRecipeVM",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instruct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RecName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepOrder = table.Column<int>(type: "int", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewRecipeVM", x => x.RecId);
                });
        }
    }
}
