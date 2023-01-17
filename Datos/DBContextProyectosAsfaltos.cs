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
		public DbSet<Rol> Roles { get; set; }
		public DbSet<RolUsuario> RolUsuarios { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Oferta> Ofertas { get; set; }
		public DbSet<Cliente> Clientes { get; set; }	
		
		#endregion

		/// <summary>
		/// Genera un ejemplo base en cada tabla
		/// </summary>
		/// <param name="model"></param>
		protected void GenerateSeedOfData(ModelBuilder model)
		{

			Cliente clienteBase = new Cliente()
			{
				ClienteID = 1,
				ClienteName = "Cliente Base"
			};
			model.Entity<Cliente>().HasData(clienteBase);


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
				Login = "admin",
				Nombre = "Administrador",
				HashContraseña = contrasena,
				Activo = true
			};
			model.Entity<Usuario>().HasData(usuarioBase);

			Rol Admin = new()
			{
				RolId = 1,
				Nombre = "Admin"
			};
			model.Entity<Rol>().HasData(Admin);

			Rol Vendedor = new()
			{
				RolId = 2,
				Nombre = "Vendedor"
			};
			model.Entity<Rol>().HasData(Vendedor);

			RolUsuario rolUsuarioBase = new()
			{
				RolUsuarioId = 1,
				RolId = Admin.RolId,
				UsuarioId = usuarioBase.UsuarioId
			};
			model.Entity<RolUsuario>().HasData(rolUsuarioBase);


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
				Autor = usuarioBase.Nombre,
				UltimaEdicion = DateTime.Today,
				UsuarioId= usuarioBase.UsuarioId,
				UltimoEditor = usuarioBase.Nombre,
				ClienteID = clienteBase.ClienteID
			};
			model.Entity<Proyecto>().HasData(ProyectoBase);

			Oferta ofertaBase = new() {
				OfertaId = 1,
				Fecha = DateTime.Today,
				Codigo = 1,
				Sellador = true,
				Asfalto = true,
				Base = true,
				SubBase = true,
				Excavacion = true,
				Monto = 100f,
				Notas = string.Empty,
				Observaciones = string.Empty,
				AutorPrespuesto = usuarioBase.Nombre,
				UltimaModificacion = DateTime.Today.AddHours(1),
				UsuarioId = usuarioBase.UsuarioId,
				Cliente = "Ejemplo"
			};
			model.Entity<Oferta>().HasData(ofertaBase);
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
		private void GetConnectionString(string connectionStringName = "")
		{
			CadenaDeConexion = "Data Source=192.168.1.15;Initial Catalog=ProyectosAsfaltos;User ID=sa;Password=Password123;encrypt=false";
		}
	}
}