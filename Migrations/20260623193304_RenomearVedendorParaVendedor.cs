using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mod5_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class RenomearVedendorParaVendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vedendor",
                table: "Alugueres",
                newName: "Vendedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendedor",
                table: "Alugueres",
                newName: "Vedendor");
        }
    }
}
