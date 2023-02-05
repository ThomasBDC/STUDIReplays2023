using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDIReplays2023.Migrations
{
    public partial class linkCategoryToReplay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryReplay",
                columns: table => new
                {
                    CategoriesLieesId = table.Column<int>(type: "int", nullable: false),
                    ReplaysLiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryReplay", x => new { x.CategoriesLieesId, x.ReplaysLiesId });
                    table.ForeignKey(
                        name: "FK_CategoryReplay_Categories_CategoriesLieesId",
                        column: x => x.CategoriesLieesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryReplay_Replays_ReplaysLiesId",
                        column: x => x.ReplaysLiesId,
                        principalTable: "Replays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryReplay_ReplaysLiesId",
                table: "CategoryReplay",
                column: "ReplaysLiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryReplay");
        }
    }
}
