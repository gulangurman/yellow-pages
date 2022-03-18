using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations
{
    public partial class FixIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7b8952-17cd-4884-8d7c-2b2df949202d", "AQAAAAEAACcQAAAAEFJDXZ3Tin3OG+4sHZ1VuebGZ31CaBeOU+MsUSFI5t4S4lI70b/ZXRS8FSywtdXnDg==", "f65b32c3-9715-4dc5-8b21-6c9fd65582df" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "344c65ea-2d9f-48db-9399-e2f803f19cfa", "AQAAAAEAACcQAAAAEPy4QKYaj00IRWwg5ehh4agSlaBczEXbccZCu7ydo00bR8/ze0kDTfdlKEXy8wZcrw==", "ed53cf7f-5723-4613-9d7f-5178a074da08" });
        }
    }
}
