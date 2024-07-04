using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreacionEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "visto",
                table: "AlertaTecnicos",
                newName: "Visto");

            migrationBuilder.RenameColumn(
                name: "codtecnico",
                table: "AlertaTecnicos",
                newName: "CodTecnico");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AlertaTecnicos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "cod_solicitud",
                table: "AlertaTecnicos",
                newName: "CodSolicitud");

            migrationBuilder.RenameColumn(
                name: "cod_empresa",
                table: "AlertaTecnicos",
                newName: "CodEmpresa");

            migrationBuilder.CreateTable(
                name: "ImagenArtTipos",
                columns: table => new
                {
                    IdImagenArtTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenArtTipos", x => x.IdImagenArtTipo);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuDocumentos = table.Column<bool>(type: "bit", nullable: false),
                    MenuEstadoTecnicos = table.Column<bool>(type: "bit", nullable: false),
                    MenuConsultaRepuestos = table.Column<bool>(type: "bit", nullable: false),
                    MenuLogsvista = table.Column<bool>(type: "bit", nullable: false),
                    MenuInfovista = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    CodEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodTecnico = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadAsignados = table.Column<int>(type: "int", nullable: false),
                    FireBaseToken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => new { x.CodEmpresa, x.CodTecnico });
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CodSolicitud = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CodSolicitudMadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodTecnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAsigCliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TiempoHSolucion = table.Column<double>(type: "float", nullable: false),
                    RutCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodOrdenServicio = table.Column<int>(type: "int", nullable: true),
                    CodUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoOs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PendienteRepuesto = table.Column<bool>(type: "bit", nullable: false),
                    RepuestoEnviado = table.Column<bool>(type: "bit", nullable: false),
                    ObsBodeguero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdImagen = table.Column<int>(type: "int", nullable: false),
                    TecnicoUsuarioCodEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TecnicoUsuarioCodTecnico = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.IdSolicitud);
                    table.ForeignKey(
                        name: "FK_Solicitudes_Tecnicos_TecnicoUsuarioCodEmpresa_TecnicoUsuarioCodTecnico",
                        columns: x => new { x.TecnicoUsuarioCodEmpresa, x.TecnicoUsuarioCodTecnico },
                        principalTable: "Tecnicos",
                        principalColumns: new[] { "CodEmpresa", "CodTecnico" });
                });

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    IdImagen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagenBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSolicitudfk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.IdImagen);
                    table.ForeignKey(
                        name: "FK_Imagenes_Solicitudes_IdSolicitudfk",
                        column: x => x.IdSolicitudfk,
                        principalTable: "Solicitudes",
                        principalColumn: "IdSolicitud",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    CodVisita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimoUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSolicitud = table.Column<int>(type: "int", nullable: false),
                    CodEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodSolicitud = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodSolicitudHija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodTecnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodOsParcial = table.Column<int>(type: "int", nullable: false),
                    Reparacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEncamino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EncaminoLongitud = table.Column<double>(type: "float", nullable: true),
                    EncaminoLatitud = table.Column<double>(type: "float", nullable: true),
                    FechaTrabajando = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrabajandoLongitud = table.Column<double>(type: "float", nullable: true),
                    TrabajandoLatitud = table.Column<double>(type: "float", nullable: true),
                    FechaTermino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminoLongitud = table.Column<double>(type: "float", nullable: true),
                    TerminoLatitud = table.Column<double>(type: "float", nullable: true),
                    FechaPendiente = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PendienteLongitud = table.Column<double>(type: "float", nullable: true),
                    PendienteLatitud = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.CodVisita);
                    table.UniqueConstraint("ICodEmpresaCodSolicitud", x => new { x.CodEmpresa, x.CodSolicitud });
                    table.ForeignKey(
                        name: "FK_Visitas_Solicitudes_IdSolicitud",
                        column: x => x.IdSolicitud,
                        principalTable: "Solicitudes",
                        principalColumn: "IdSolicitud",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagenArtes",
                columns: table => new
                {
                    IdImagenArt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    IdTipoImagenart = table.Column<int>(type: "int", nullable: false),
                    Imagenb64 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenArtes", x => x.IdImagenArt);
                    table.ForeignKey(
                        name: "FK_ImagenArtes_ImagenArtTipos_IdTipoImagenart",
                        column: x => x.IdTipoImagenart,
                        principalTable: "ImagenArtTipos",
                        principalColumn: "IdImagenArtTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagenArtes_Visitas_IdVisita",
                        column: x => x.IdVisita,
                        principalTable: "Visitas",
                        principalColumn: "CodVisita",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagenArtes_IdTipoImagenart",
                table: "ImagenArtes",
                column: "IdTipoImagenart");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenArtes_IdVisita",
                table: "ImagenArtes",
                column: "IdVisita");

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_IdSolicitudfk",
                table: "Imagenes",
                column: "IdSolicitudfk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_CodEmpresa_CodSolicitud",
                table: "Solicitudes",
                columns: new[] { "CodEmpresa", "CodSolicitud" },
                unique: true,
                filter: "[CodEmpresa] IS NOT NULL AND [CodSolicitud] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_TecnicoUsuarioCodEmpresa_TecnicoUsuarioCodTecnico",
                table: "Solicitudes",
                columns: new[] { "TecnicoUsuarioCodEmpresa", "TecnicoUsuarioCodTecnico" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRol",
                table: "Usuarios",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_CodEmpresa_CodSolicitud",
                table: "Visitas",
                columns: new[] { "CodEmpresa", "CodSolicitud" });

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_IdSolicitud",
                table: "Visitas",
                column: "IdSolicitud");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenArtes");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ImagenArtTipos");

            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.RenameColumn(
                name: "Visto",
                table: "AlertaTecnicos",
                newName: "visto");

            migrationBuilder.RenameColumn(
                name: "CodTecnico",
                table: "AlertaTecnicos",
                newName: "codtecnico");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AlertaTecnicos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CodSolicitud",
                table: "AlertaTecnicos",
                newName: "cod_solicitud");

            migrationBuilder.RenameColumn(
                name: "CodEmpresa",
                table: "AlertaTecnicos",
                newName: "cod_empresa");
        }
    }
}
