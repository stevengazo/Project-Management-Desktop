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
						i.FechaOC.ToShortTimeString(),
						i.OfertaId,
						i.FechaInicio.ToShortTimeString(),
						i.FechaFinal.ToShortTimeString(),
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


				DataGridViewButtonColumn botonEditar = new();
				botonEditar.HeaderText = "Editar";
				botonEditar.Text = "Editar";
				botonEditar.Name = "btnEditarProyecto";
				botonEditar.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonEditar);
			}
		}

		private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.ColumnIndex == 0)
			{
				VerProyecto verProyecto = new();
				var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
				verProyecto.idProyecto = id;
				verProyecto.ShowDialog();
			}
			else if(e.ColumnIndex == 1)
			{
				EditarProyecto editarProyecto = new();
				editarProyecto.ShowDialog();
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

		private void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
		}
	}
}
