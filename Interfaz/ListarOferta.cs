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

		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
