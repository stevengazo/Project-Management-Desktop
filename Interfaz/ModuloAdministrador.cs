using Modelos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
	public partial class ModuloAdministrador : Form
	{
		private List<Usuario> Vendedores = new();
		private List<Proyecto> proyectos = new();
		public ModuloAdministrador()
		{
			InitializeComponent();
			CargarVendedores();
			CargarTabla();
		}

		private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarUsuario listarUsuario = new();
			listarUsuario.ShowDialog();
		}

		private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AgregarUsuario agregarUsuario = new();
			agregarUsuario.ShowDialog();
		}

		private void CargarVendedores()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = usuarioNegocio.ListarVendedores();
			if (Vendedores.Count > 0)
			{
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}
		private void CargarTabla()
		{
			var proyectosNegocio = new ProyectoNegocios();
			proyectos = proyectosNegocio.ListaProyectos();
			if (proyectos.Count > 0)
			{
				DataTable _tabla = new();

				_tabla.Columns.Add("Numero Proyecto");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Raz[on Social");
				_tabla.Columns.Add("Fecha OC");
				_tabla.Columns.Add("Oferta");
				_tabla.Columns.Add("Fecha Inicio");
				_tabla.Columns.Add("Fecha Final");
				_tabla.Columns.Add("Monto");
				_tabla.Columns.Add("Estado");


				foreach (Proyecto i in proyectos)
				{
					_tabla.Rows.Add(
						i.ProyectoId,
						i.Vendedor.Nombre,
						i.FechaOC,
						i.OfertaId,
						i.FechaInicio.ToLongDateString(),
						i.FechaFinal.ToLongDateString(),
						i.Monto,
						i.Estado
						);
				}

				dgvProyectos.DataSource = _tabla;

				DataGridViewButtonColumn botonVer = new();
				botonVer.HeaderText = "Ver";
				botonVer.Text = "Ver";
				botonVer.Name = "btnVerProyecto";
				botonVer.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonVer);
			}
		}

		private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				 if (e.ColumnIndex == 9)
				{
					VerProyecto verProyecto = new();
					var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[0].Value.ToString());
					verProyecto.idProyecto = id;
					verProyecto.ShowDialog();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ModuloAdministrador_Load(object sender, EventArgs e)
		{

		}
		private void NumeroProyecto()
		{
			try
			{

			}catch (Exception f)
			{
				MessageBox.Show("Error interno","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void listarOfertasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarOferta listarOferta = new();
			listarOferta.ShowDialog();
		}
	}
}
