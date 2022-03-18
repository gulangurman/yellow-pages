using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations
{
    public partial class AddedCustomIdentityClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02174cf0–9412–4cfe-afbf-59f706d72cf6", "Test user account.", 0, "344c65ea-2d9f-48db-9399-e2f803f19cfa", "testuser@example.com", false, false, null, "test_user_01", "TESTUSER@EXAMPLE.COM", "TESTUSER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPy4QKYaj00IRWwg5ehh4agSlaBczEXbccZCu7ydo00bR8/ze0kDTfdlKEXy8wZcrw==", "5551234567", false, "ed53cf7f-5723-4613-9d7f-5178a074da08", false, "testuser@example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, "fcd6c096-9b7c-4e2d-89e0-6f16402db1b6", "testuser@example.com", false, false, null, null, "TESTUSER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKLkfAp0XWPlqwDnPjiDlLLw0vjvsgzPOCDhh4Cbmw05yV/0w/aCXeYU53Z9O3vhEQ==", null, false, "b61f2726-b5fa-4670-9796-82764d5bb322", false, "Test User" });
        }
    }
}
