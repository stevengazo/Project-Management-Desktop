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
		public ModuloAdministrador()
		{
			InitializeComponent();
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

		private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if(e.ColumnIndex== 0)
				{

				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
