using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    HashContraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    OfertaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    DDCE = table.Column<bool>(type: "bit", nullable: false),
                    Ionizante = table.Column<bool>(type: "bit", nullable: false),
                    Supresor = table.Column<bool>(type: "bit", nullable: false),
                    Torre = table.Column<bool>(type: "bit", nullable: false),
                    Malla = table.Column<bool>(type: "bit", nullable: false),
                    Otros = table.Column<bool>(type: "bit", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EncargadoCotizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorPrespuesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concluida = table.Column<bool>(type: "bit", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.OfertaId);
                    table.ForeignKey(
                        name: "FK_Ofertas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    FechaOC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfertaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    PorcentajeAnticipo = table.Column<int>(type: "int", nullable: false),
                    FacturaAnticipoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacturaFinalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TareaId = table.Column<int>(type: "int", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoEditor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                    table.ForeignKey(
                        name: "FK_Proyectos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolUsuarios",
                columns: table => new
                {
                    RolUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuarios", x => x.RolUsuarioId);
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    CotizacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trabajadores = table.Column<int>(type: "int", nullable: false),
                    DiasLaborales = table.Column<float>(type: "real", nullable: false),
                    MontoMO = table.Column<float>(type: "real", nullable: false),
                    MontoKM = table.Column<float>(type: "real", nullable: false),
                    MontoMaterial = table.Column<float>(type: "real", nullable: false),
                    MontoProductos = table.Column<float>(type: "real", nullable: false),
                    MontoViaticos = table.Column<float>(type: "real", nullable: false),
                    Imprevisto = table.Column<float>(type: "real", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsPublico = table.Column<bool>(type: "bit", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Creación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RutaArchivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimoEditor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfertaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.CotizacionId);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Ofertas_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "Ofertas",
                        principalColumn: "OfertaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Informes",
                columns: table => new
                {
                    InformeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaMaxima = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tecnico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concluido = table.Column<bool>(type: "bit", nullable: false),
                    UltimoEditor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informes", x => x.InformeId);
                    table.ForeignKey(
                        name: "FK_Informes_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Informes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoEditor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.NotaId);
                    table.ForeignKey(
                        name: "FK_Notas_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Vendedor" },
                    { 3, "Asistente" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Activo", "HashContraseña", "Login", "Nombre" },
                values: new object[] { 1, true, "0192023A7BBD73250516F069DF18B500", "admin", "Administrador" });

            migrationBuilder.InsertData(
                table: "Ofertas",
                columns: new[] { "OfertaId", "AutorPrespuesto", "Categoria", "Cliente", "Codigo", "Concluida", "DDCE", "EncargadoCotizador", "Estado", "Fecha", "Ionizante", "Malla", "Monto", "Notas", "Observaciones", "Otros", "Provincia", "Supresor", "Torre", "UltimaModificacion", "UsuarioId" },
                values: new object[] { 1, "Administrador", "Instalación", "Ejemplo", 1, true, true, "Gabriel", "Pendiente", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), true, true, 100f, "", "", true, "San José", true, true, new DateTime(2024, 1, 16, 1, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "ProyectoId", "Autor", "Cliente", "Contacto", "Enable", "Estado", "FacturaAnticipoId", "FacturaFinalId", "FechaFinal", "FechaInicio", "FechaOC", "Monto", "OfertaId", "PorcentajeAnticipo", "Provincia", "TareaId", "Tipo", "Ubicacion", "UltimaEdicion", "UltimoEditor", "UsuarioId" },
                values: new object[] { 1, "Administrador", "Ejemplo de Cliente", "Ejemplo", true, "Finalizado", "No existente", "No Existente", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 1, 16, 15, 10, 18, 743, DateTimeKind.Local).AddTicks(5314), 100f, "PS-00001", 50, "", 2000, "Instalación", "Grupo Mecsa", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Administrador", 1 });

            migrationBuilder.InsertData(
                table: "RolUsuarios",
                columns: new[] { "RolUsuarioId", "RolId", "UsuarioId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_OfertaId",
                table: "Cotizaciones",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_Informes_ProyectoId",
                table: "Informes",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Informes_UsuarioId",
                table: "Informes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_ProyectoId",
                table: "Notas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_UsuarioId",
                table: "Ofertas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_UsuarioId",
                table: "Proyectos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_RolId",
                table: "RolUsuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_UsuarioId",
                table: "RolUsuarios",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Informes");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "RolUsuarios");

            migrationBuilder.DropTable(
                name: "Ofertas");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
