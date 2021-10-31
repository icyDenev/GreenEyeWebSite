using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LitWebSite.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SensorsData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CO = table.Column<decimal>(nullable: false),
                    CO2 = table.Column<decimal>(nullable: false),
                    NO2 = table.Column<decimal>(nullable: false),
                    PM25 = table.Column<decimal>(nullable: false),
                    DownLeftLongtitute = table.Column<decimal>(nullable: false),
                    DownLeftLatitude = table.Column<decimal>(nullable: false),
                    UpRightLongtitude = table.Column<decimal>(nullable: false),
                    UpRightLatitude = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorsData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorsData");
        }
    }
}
