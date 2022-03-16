using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations
{
    public partial class SeedTestUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, "fcd6c096-9b7c-4e2d-89e0-6f16402db1b6", "testuser@example.com", false, false, null, null, "TESTUSER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKLkfAp0XWPlqwDnPjiDlLLw0vjvsgzPOCDhh4Cbmw05yV/0w/aCXeYU53Z9O3vhEQ==", null, false, "b61f2726-b5fa-4670-9796-82764d5bb322", false, "Test User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");
        }
    }
}
