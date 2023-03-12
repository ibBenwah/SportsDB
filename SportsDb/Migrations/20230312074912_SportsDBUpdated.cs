using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsDb.Migrations
{
    /// <inheritdoc />
    public partial class SportsDBUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SportId",
                table: "Leagues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SportId",
                table: "Leagues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
