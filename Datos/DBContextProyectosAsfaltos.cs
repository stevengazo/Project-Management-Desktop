using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;

namespace Modelos

// use EntityFrameworkCore\Add-Migration sample
///
///
{
	public class DBContextProyectosAsfaltos : DbContext
	{
		#region  Internal Attributes
		internal string CadenaDeConexion { get; set; }
		internal IConfiguration Configuracion { get; set; }
		#endregion

		#region Atributos Publicos
		public DbSet<Proyecto> Proyectos { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Rol> Roles { get; set; }
		public DbSet<RolUsuario> RolUsuarios { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Vendedor> Vendedores { get; set; }
		#endregion

		/// <summary>
		/// Genera un ejemplo base en cada tabla
		/// </summary>
		/// <param name="model"></param>
		protected void GenerateSeedOfData(ModelBuilder model)
		{

			Cliente ClienteBase = new()
			{
				ClienteId = 1,
				Cedula = 1,
				RazonSocial = "Ejemplo S.A",
				NombreComercial = "Ejemplo"
			};
			model.Entity<Cliente>().HasData(ClienteBase);
			Vendedor VendedorBase = new()
			{
				VendedorId = 1,
				Nombre = "Ejemplo"
			};
			model.Entity<Vendedor>().HasData(VendedorBase);
			Proyecto ProyectoBase = new()
			{
				ProyectoId = 1,
				FechaOC = DateTime.Now,
				Contacto = "Ejemplo",
				OfertaId = "PS-00001",
				Monto = 100f,
				PorcentajeAnticipo = 50,
				FacturaAnticipoId = "No existente",
				FacturaFinalId = "No Existente",
				TareaId = 2000,
				Ubicacion = "Grupo Mecsa",
				FechaInicio = DateTime.Today.AddDays(-1),
				FechaFinal = DateTime.Today.AddDays(2),
				Estado = "Finalizado",
				Autor = "Ejemplo",
				UltimaEdicion = DateTime.Today,
				VendedorId = VendedorBase.VendedorId,
				ClienteId = ClienteBase.ClienteId
			};
			model.Entity<Proyecto>().HasData(ProyectoBase);
			var contrasena = "admin123";
			using (var md6Hash = MD5.Create())
			{
				var fuente = Encoding.UTF8.GetBytes(contrasena);
				var hashBytes = md6Hash.ComputeHash(fuente);
				var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
				contrasena = hash;
			}
			Usuario usuarioBase = new()
			{
				UsuarioId = 1,
				Nombre = "admin",
				HashContraseña = contrasena,
			};
			model.Entity<Usuario>().HasData(usuarioBase);
			Rol Editor = new()
			{
				RolId = 1,
				Nombre = "Editor"
			};
			model.Entity<Rol>().HasData(Editor);
			RolUsuario rolUsuarioBase = new()
			{
				RolUsuarioId=1,
				RolId = Editor.RolId,
				UsuarioId = usuarioBase.UsuarioId
			};
			model.Entity<RolUsuario>().HasData(rolUsuarioBase);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
			base.OnModelCreating(modelBuilder);
			GenerateSeedOfData(modelBuilder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// You don't actually ever need to call this
			if (!optionsBuilder.IsConfigured)
			{
				GetConnectionString();
				optionsBuilder.UseSqlServer(CadenaDeConexion);
			}
		}

		private void GetConnectionString(string connectionStringName = "RayosNoConnection")
		{
			CadenaDeConexion = "Data Source=192.168.1.15;Initial Catalog=ProyectosAsfaltos;User ID=sa;Password=Password123;encrypt=false";
		}
	}
}