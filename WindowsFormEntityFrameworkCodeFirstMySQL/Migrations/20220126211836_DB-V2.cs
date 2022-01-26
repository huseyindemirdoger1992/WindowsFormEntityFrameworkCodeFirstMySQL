using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormEntityFrameworkCodeFirstMySQL.Migrations
{
    public partial class DBV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DogumYili",
                table: "Personel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogumYili",
                table: "Personel");
        }
    }
}
