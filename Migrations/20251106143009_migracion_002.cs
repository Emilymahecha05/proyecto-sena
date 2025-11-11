using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_proyecto_sena.Migrations
{
    /// <inheritdoc />
    public partial class migracion_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usurio_correo",
                table: "usuarios",
                newName: "usuario_correo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuario_correo",
                table: "usuarios",
                newName: "usurio_correo");
        }
    }
}
