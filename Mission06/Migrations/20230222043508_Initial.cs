using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CatId = table.Column<int>(nullable: false),
                    CategoryCatId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_CategoryCatId",
                        column: x => x.CategoryCatId,
                        principalTable: "Categories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[] { 3, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[] { 5, "N/A" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "CatId", "CategoryCatId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 2, null, "Akiva Schaffer", false, null, null, "PG-13", "Hot Rod", 2007 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "CatId", "CategoryCatId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 1, null, "Anthony Russo", false, null, null, "PG-13", "The Avengers", 2012 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "CatId", "CategoryCatId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 2, null, "Tom McGrath", false, null, null, "PG  ", "Megamind", 2010 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryCatId",
                table: "Responses",
                column: "CategoryCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
