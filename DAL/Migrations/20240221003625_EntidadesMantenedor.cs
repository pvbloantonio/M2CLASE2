using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class EntidadesMantenedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    NumInt = table.Column<int>(type: "int", nullable: false),
                    NumDouble = table.Column<double>(type: "float", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnvioCorreo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Para = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvioCorreo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodTecnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MantenedorArea",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantenedorArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicioWindows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioWindows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MantenedorRepuesto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdArea = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantenedorRepuesto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MantenedorRepuesto_MantenedorArea_IdArea",
                        column: x => x.IdArea,
                        principalTable: "MantenedorArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MantenedorRepuesto_IdArea",
                table: "MantenedorRepuesto",
                column: "IdArea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");

            migrationBuilder.DropTable(
                name: "EnvioCorreo");

            migrationBuilder.DropTable(
                name: "InfoLog");

            migrationBuilder.DropTable(
                name: "MantenedorRepuesto");

            migrationBuilder.DropTable(
                name: "ServicioWindows");

            migrationBuilder.DropTable(
                name: "MantenedorArea");
        }
    }
}
