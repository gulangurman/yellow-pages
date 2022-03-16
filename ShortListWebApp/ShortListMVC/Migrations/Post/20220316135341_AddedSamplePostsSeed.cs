using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    public partial class AddedSamplePostsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AccountId", "CategoryId", "Content", "ImageUrl", "Tags", "Title" },
                values: new object[] { 1, "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 1, "Kedimiz Bıdık kaybolmuştur.", "https://www.markuptag.com/images/image-six.jpg", "kedi", "Kayıp kedi" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AccountId", "CategoryId", "Content", "ImageUrl", "Tags", "Title" },
                values: new object[] { 2, "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 3, "Acil eleman aranıyor.", "https://www.markuptag.com/images/image-two.jpg", "eleman", "Eleman aranıyor" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AccountId", "CategoryId", "Content", "ImageUrl", "Tags", "Title" },
                values: new object[] { 3, "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 4, "İkinci el cep telefonu.", "https://www.markuptag.com/images/image-three.jpg", "telefon", "Satılık telefon" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AccountId", "CategoryId", "Content", "ImageUrl", "Tags", "Title" },
                values: new object[] { 4, "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 6, "Sahilde konser etkinliğinde buluşuyoruz.", "https://www.markuptag.com/images/image-four.jpg", "konser", "Sahil konserleri" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
