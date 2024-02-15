using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

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
        public DbSet<Cotizacion> Cotizaciones { get; set; } 
        public DbSet<Informe> Informes { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        //public DbSet<Cliente> Clientes { get; set; }	

        #endregion

        /// <summary>
        /// Genera un ejemplo base en cada tabla
        /// </summary>
        /// <param name="model"></param>
        protected void GenerateSeedOfData(ModelBuilder model)
        {

            /*	Cliente clienteBase = new Cliente()
				{
					ClienteID = 1,
					ClienteName = "Cliente Base"
				};
				model.Entity<Cliente>().HasData(clienteBase);
			*/

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

            Rol Asistente = new() 
            { 
                RolId=3,
                Nombre="Asistente"
            };
            model.Entity<Rol>().HasData(Asistente);


            RolUsuario rolUsuarioBase = new()
            {
                RolUsuarioId = 1,
                RolId = Admin.RolId,
                UsuarioId = usuarioBase.UsuarioId
            };
            RolUsuario rolUsuarioOferta = new()
            {
                RolUsuarioId = 2,
                RolId = Vendedor.RolId,
                UsuarioId = usuarioBase.UsuarioId
            };
            model.Entity<RolUsuario>().HasData(rolUsuarioBase);
            model.Entity<RolUsuario>().HasData(rolUsuarioOferta);


            Proyecto ProyectoBase = new()
            {
                ProyectoId = 1,
                FechaOC = DateTime.Now,
                Descripcion= "Proyecto de ejemplo",
                Cliente = "Ejemplo de Cliente",
                OrdenCompra = "Numero Orden",
                OfertaId = "PS-00001",
                TipoMoneda = "Colon",
                Monto = 100f,
                Cedula = "2894043",
                PorcentajeAnticipo = 50,
                MontoIVA= 13,
                EsPublico = true,
                TareaId = 2000,
                Ubicacion = "Grupo Mecsa",
                Tipo = "Instalación",
                FechaIngreso = DateTime.Now,
                Estado = "Finalizado",
                Provincia = "",
                Autor = usuarioBase.Nombre,
                UltimaEdicion = DateTime.Today,
                UsuarioId = usuarioBase.UsuarioId,
                UltimoEditor = usuarioBase.Nombre,
                Enable = true,
                Finalizado = false
                //ClienteID = clienteBase.ClienteID
            };
            model.Entity<Proyecto>().HasData(ProyectoBase);

            Oferta ofertaBase = new()
            {
                OfertaId = 1,
                Fecha = DateTime.Today,
                Codigo = 1,
                Monto = 100f,
                Notas = string.Empty,
                DDCE = true,
                Ionizante = true,
                Malla = true,
                Torre = true,
                Otros = true,
                Supresor = true,
                Categoria = "Instalación",
                Provincia = "San José",
                Observaciones = string.Empty,
                AutorPrespuesto = usuarioBase.Nombre,
                UltimaModificacion = DateTime.Today.AddHours(1),
                UsuarioId = usuarioBase.UsuarioId,
                Estado = "Pendiente",
                Concluida = true,
                Cliente = "Ejemplo",
                EncargadoCotizador = "Gabriel"
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
        private void GetConnectionString(string connectionStringName = "DBAsfaltos")
        {
            CadenaDeConexion = XMLConfiguraciones.LeerCadenaDeConexion();
        }

        public void GenerateDB()
        {
            try
            {
                var connected = this.Database.CanConnect();
                if (!connected)
                {
                    Console.WriteLine("Trying to generate the database...");
                    this.Database.Migrate();
                }

            }
            catch (Exception f)
            {
                Console.WriteLine("Error: " + f.Message);
            }
        }

    }
}