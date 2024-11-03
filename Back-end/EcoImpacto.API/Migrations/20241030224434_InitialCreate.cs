using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculatorData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsumoEnergiaKWh = table.Column<double>(type: "double precision", nullable: false),
                    ConsumoGasM3 = table.Column<double>(type: "double precision", nullable: false),
                    ConsumoCombustivelLitros = table.Column<double>(type: "double precision", nullable: false),
                    ConsumoVeiculoKmPorLitro = table.Column<double>(type: "double precision", nullable: false),
                    TransportePublicoKm = table.Column<double>(type: "double precision", nullable: false),
                    PraticasReciclagem = table.Column<int>(type: "integer", nullable: false),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false),
                    EmailUsuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculatorData");
        }
    }
}
