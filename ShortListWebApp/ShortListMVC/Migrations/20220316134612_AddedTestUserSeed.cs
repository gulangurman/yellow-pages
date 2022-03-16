using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations
{
    public partial class AddedTestUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, "cb453aac-557f-481f-ba97-dadd9f5dc69a", "testuser@example.com", false, false, null, null, "TESTUSER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHivnH7TbE4i9HV2MMSyyi/bEMKtYOUh40GIdTkwW5rMsjtoO+3jM29DWDaKQDnkLw==", null, false, "76154faf-fa8f-4fe9-baf5-90c7d9821d33", false, "Test User" });
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
