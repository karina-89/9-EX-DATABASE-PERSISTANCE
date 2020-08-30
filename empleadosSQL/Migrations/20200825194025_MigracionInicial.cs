using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace empleadosSQL.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpleadoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    Sueldo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoItems", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "EmpleadoItems",
                columns: new[] { "Id", "Apellidos", "Cargo", "Nombre", "Sueldo" },
                values: new object[,]
                {
                    { 1, "Pérez", "Administrativo", "Juan", 24000.0 },
                    { 2, "López", "Administrativa", "Marta", 24000.0 },
                    { 3, "Rodríguez", "Mozo de almacén", "Raúl", 20000.0 },
                    { 4, "Guijarro", "Comercial", "Luís", 26000.0 },
                    { 5, "Sánchez", "Ventas", "Núria", 26000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadoItems");
        }
    }
}
