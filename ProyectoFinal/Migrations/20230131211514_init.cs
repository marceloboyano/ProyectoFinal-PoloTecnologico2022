using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorialBolilleros",
                columns: table => new
                {
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroBolilla = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialBolilleros", x => x.FechaHora);
                });

            migrationBuilder.CreateTable(
                name: "HistorialCartones",
                columns: table => new
                {
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Carton1 = table.Column<int>(type: "int", nullable: true),
                    Carton2 = table.Column<int>(type: "int", nullable: true),
                    Carton3 = table.Column<int>(type: "int", nullable: true),
                    Carton4 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialCartones", x => x.FechaHora);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialBolilleros");

            migrationBuilder.DropTable(
                name: "HistorialCartones");
        }
    }
}
