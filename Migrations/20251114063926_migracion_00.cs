using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_proyecto_sena.Migrations
{
    /// <inheritdoc />
    public partial class migracion_00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usuario_sait",
                table: "usuarios");

            migrationBuilder.AddColumn<string>(
                name: "usuario_salt",
                table: "usuarios",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usuario_salt",
                table: "usuarios");

            migrationBuilder.AddColumn<string>(
                name: "usuario_sait",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
