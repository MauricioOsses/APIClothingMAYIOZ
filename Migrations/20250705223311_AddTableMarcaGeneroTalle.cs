using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIClothingMAYIOZ.Migrations
{
    /// <inheritdoc />
    public partial class AddTableMarcaGeneroTalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Talle",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "IdGenero",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTalle",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGenero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMarca = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Talles",
                columns: table => new
                {
                    IdTalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTalle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talles", x => x.IdTalle);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdGenero",
                table: "Productos",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdMarca",
                table: "Productos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdTalle",
                table: "Productos",
                column: "IdTalle");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Generos_IdGenero",
                table: "Productos",
                column: "IdGenero",
                principalTable: "Generos",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_IdMarca",
                table: "Productos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Talles_IdTalle",
                table: "Productos",
                column: "IdTalle",
                principalTable: "Talles",
                principalColumn: "IdTalle",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Generos_IdGenero",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_IdMarca",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Talles_IdTalle",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Talles");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdGenero",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdMarca",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdTalle",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IdGenero",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IdTalle",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Talle",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
