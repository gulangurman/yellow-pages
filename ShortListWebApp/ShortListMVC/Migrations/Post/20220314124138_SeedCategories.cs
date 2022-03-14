using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 1, "dinner", "Kayıp", "lost" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 2, "home", "Evcil Hayvanlar", "pets" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 3, "tshirt", "Eleman Aranıyor", "hiring" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 4, "travel", "İkinci El", "secondhand" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 5, "jobs", "Serbest Çalışanlar", "hiring" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 6, "bullhorn", "Etkinlikler", "hiring" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name", "Slug" },
                values: new object[] { 7, "bolt", "Ev yapımı", "handmade" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
