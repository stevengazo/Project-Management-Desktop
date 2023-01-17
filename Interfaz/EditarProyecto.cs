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
	public partial class EditarProyecto : Form
	{
		public EditarProyecto()
		{
			InitializeComponent();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			var Resultado = MessageBox.Show("¿Deseas borrar este proyecto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		}
	}
}
