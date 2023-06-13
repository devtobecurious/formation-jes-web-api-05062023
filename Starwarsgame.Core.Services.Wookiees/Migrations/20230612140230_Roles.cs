using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starwarsgame.Core.Wookiees.Services.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleWookiee",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    WookieesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleWookiee", x => new { x.RolesId, x.WookieesId });
                    table.ForeignKey(
                        name: "FK_RoleWookiee_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleWookiee_Wookiee_WookieesId",
                        column: x => x.WookieesId,
                        principalTable: "Wookiee",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleWookiee_WookieesId",
                table: "RoleWookiee",
                column: "WookieesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleWookiee");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
