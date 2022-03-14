using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    public partial class AddedCategorySlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Category",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Category");
        }
    }
}
