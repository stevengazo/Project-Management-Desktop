using Modelos;
using Negocio;
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
	public partial class ListarOferta : Form
	{
		public ListarOferta()
		{
			InitializeComponent();
		}

		private void ListarOferta_Load(object sender, EventArgs e)
		{
			if (Temporal.TipoLogin.Equals("Administrador"))
			{
				CargarTablaAdministradores();
			}
			else
			{
				CargarTablaVendedores();
			}
		
		}

		private void CargarTablaVendedores()
		{
			int IdUsuario = Temporal.UsuarioActivo.UsuarioId;
			

		}
		private void CargarTablaAdministradores()
		{
			OfertaNegocio ofertaNegocio = new();
			var listaOfertas = ofertaNegocio.ListaOfertas();
			if(listaOfertas.Count > 0)
			{
				DataTable _tabla = new();
				_tabla.Columns.Add("Oferta Id");
				_tabla.Columns.Add("Fecha");
				_tabla.Columns.Add("Codigo");
				_tabla.Columns.Add("Sellador");
				_tabla.Columns.Add("Asfalto");
				_tabla.Columns.Add("SubBase");
				_tabla.Columns.Add("Excavacion");
				_tabla.Columns.Add("Monto");
				_tabla.Columns.Add("Encargado");

				foreach (Oferta item in listaOfertas)
				{
					_tabla.Rows.Add(
						item.OfertaId.ToString(),
						item.Fecha.ToLongDateString(),
						item.Codigo,
						item.Sellador,
						item.Asfalto,
						item.SubBase,
						item.Excavacion,
						item.Monto,
						item.Encargado.Nombre
						) ;
				}
				dgvOfertas.DataSource= _tabla;
			}
			else
			{

			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
		}
	}
}
