using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Datos.Migrations
{
	/// <inheritdoc />
	public partial class migracion : Migration
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
					OfertaId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
					Codigo = table.Column<int>(type: "int", nullable: false),
					Sellador = table.Column<bool>(type: "bit", nullable: false),
					Asfalto = table.Column<bool>(type: "bit", nullable: false),
					Base = table.Column<bool>(type: "bit", nullable: false),
					SubBase = table.Column<bool>(type: "bit", nullable: false),
					Excavacion = table.Column<bool>(type: "bit", nullable: false),
					Monto = table.Column<float>(type: "real", nullable: false),
					Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
					EncargadoCotizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
					AutorPrespuesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
					ProyectoId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FechaOC = table.Column<DateTime>(type: "datetime2", nullable: false),
					Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
					OfertaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Monto = table.Column<float>(type: "real", nullable: false),
					PorcentajeAnticipo = table.Column<int>(type: "int", nullable: false),
					FacturaAnticipoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					FacturaFinalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TareaId = table.Column<int>(type: "int", nullable: false),
					Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

			migrationBuilder.InsertData(
				table: "Roles",
				columns: new[] { "RolId", "Nombre" },
				values: new object[,]
				{
					{ 1, "Admin" },
					{ 2, "Vendedor" }
				});

			migrationBuilder.InsertData(
				table: "Usuarios",
				columns: new[] { "UsuarioId", "Activo", "HashContraseña", "Login", "Nombre" },
				values: new object[] { 1, true, "0192023A7BBD73250516F069DF18B500", "admin", "Administrador" });

			migrationBuilder.InsertData(
				table: "Ofertas",
				columns: new[] { "OfertaId", "Asfalto", "AutorPrespuesto", "Base", "Cliente", "Codigo", "EncargadoCotizador", "Excavacion", "Fecha", "Monto", "Notas", "Observaciones", "Sellador", "SubBase", "UltimaModificacion", "UsuarioId" },
				values: new object[] { 1, true, "Administrador", true, "Ejemplo", 1, "Gabriel", true, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 100f, "", "", true, true, new DateTime(2023, 1, 27, 1, 0, 0, 0, DateTimeKind.Local), 1 });

			migrationBuilder.InsertData(
				table: "Proyectos",
				columns: new[] { "ProyectoId", "Autor", "Cliente", "Contacto", "Enable", "Estado", "FacturaAnticipoId", "FacturaFinalId", "FechaFinal", "FechaInicio", "FechaOC", "Monto", "OfertaId", "PorcentajeAnticipo", "TareaId", "Ubicacion", "UltimaEdicion", "UltimoEditor", "UsuarioId" },
				values: new object[] { 1, "Administrador", "Ejemplo de Cliente", "Ejemplo", true, "Finalizado", "No existente", "No Existente", new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 27, 11, 4, 47, 613, DateTimeKind.Local).AddTicks(564), 100f, "PS-00001", 50, 2000, "Grupo Mecsa", new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Administrador", 1 });

			migrationBuilder.InsertData(
				table: "RolUsuarios",
				columns: new[] { "RolUsuarioId", "RolId", "UsuarioId" },
				values: new object[] { 1, 1, 1 });

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
				name: "Ofertas");

			migrationBuilder.DropTable(
				name: "Proyectos");

			migrationBuilder.DropTable(
				name: "RolUsuarios");

			migrationBuilder.DropTable(
				name: "Roles");

			migrationBuilder.DropTable(
				name: "Usuarios");
		}
	}
}
