using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityApp.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DomesticUsers",
                columns: table => new
                {
                    Network = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjIdNum = table.Column<int>(type: "int", nullable: false),
                    UsedElectricity = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProducedElectricity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticUsers", x => x.Network);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomesticUsers");
        }
    }
}
