using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starwarsgame.Core.Wookiees.Services.Migrations
{
    public partial class AddGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Wookiee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Wookiee");
        }
    }
}
