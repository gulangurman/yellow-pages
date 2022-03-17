using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    public partial class AddedCityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityId",
                table: "Post",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_CityId",
                table: "Post",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_City_CityId",
                table: "Post",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_City_CityId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Post_CityId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Post");
        }
    }
}
