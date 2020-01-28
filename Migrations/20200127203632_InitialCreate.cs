using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngName = table.Column<string>(nullable: false),
                    UM = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngId);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    RecId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepOrder = table.Column<int>(nullable: false),
                    Instruct = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "UserRegistration",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Confirmpwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistration", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecName = table.Column<string>(nullable: false),
                    Calories = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TagIdfk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_Recipes_Tags_TagIdfk",
                        column: x => x.TagIdfk,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngQuant",
                columns: table => new
                {
                    RecIdfk = table.Column<int>(nullable: true),
                    IngIdfk = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    //table.PrimaryKey("PK_IngQuant", x => x.RecIdfk, IngIdfk);///TODO make this table have two primary keys or no primary key at all 
                    table.ForeignKey(
                        name: "FK_IngQuant_Ingredients_IngIdfk",
                        column: x => x.IngIdfk,
                        principalTable: "Ingredients",
                        principalColumn: "IngId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngQuant_Recipes_RecIdfk",
                        column: x => x.RecIdfk,
                        principalTable: "Recipes",
                        principalColumn: "RecId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_IngIdfk",
                table: "IngQuant",
                column: "IngIdfk");

            migrationBuilder.CreateIndex(
                name: "IX_IngQuant_RecIdfk",
                table: "IngQuant",
                column: "RecIdfk");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagIdfk",
                table: "Recipes",
                column: "TagIdfk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngQuant");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "UserRegistration");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
