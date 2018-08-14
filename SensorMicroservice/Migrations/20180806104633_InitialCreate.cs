using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SensorMicroservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Alesta");

            migrationBuilder.CreateTable(
                name: "AirQuality",
                columns: table => new
                {
                    HardwareId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirQuality", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestRoom",
                columns: table => new
                {
                    BeginProcess = table.Column<DateTime>(nullable: false),
                    EndProcess = table.Column<DateTime>(nullable: false),
                    HardwareId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestRoom", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Coffee",
                schema: "Alesta",
                columns: table => new
                {
                    HardwareId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeginProcess = table.Column<DateTime>(nullable: false),
                    EndProcess = table.Column<DateTime>(nullable: false),
                    CurrentLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffee", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirQuality");

            migrationBuilder.DropTable(
                name: "RestRoom");

            migrationBuilder.DropTable(
                name: "Coffee",
                schema: "Alesta");
        }
    }
}
