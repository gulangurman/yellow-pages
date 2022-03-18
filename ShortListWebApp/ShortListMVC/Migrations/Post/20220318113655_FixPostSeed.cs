using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    public partial class FixPostSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountId",
                value: "02174cf0–9412–4cfe-afbf-59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountId",
                value: "02174cf0–9412–4cfe-afbf-59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountId",
                value: "02174cf0–9412–4cfe-afbf-59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountId",
                value: "02174cf0–9412–4cfe-afbf-59f706d72cf6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountId",
                value: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountId",
                value: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountId",
                value: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountId",
                value: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");
        }
    }
}
