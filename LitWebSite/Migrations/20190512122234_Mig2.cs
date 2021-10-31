using Microsoft.EntityFrameworkCore.Migrations;

namespace LitWebSite.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NO2",
                table: "SensorsData",
                newName: "O3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "O3",
                table: "SensorsData",
                newName: "NO2");
        }
    }
}
