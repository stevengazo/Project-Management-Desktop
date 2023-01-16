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
using Modelos;
namespace Interfaz
{
	public partial class VerProyecto : Form
	{
		public int idProyecto { get; set; } = 0;
		public VerProyecto()
		{
			InitializeComponent();
		}

		private void VerProyecto_Load(object sender, EventArgs e)
		{
			CargarProyectoDetallado();
		}

		private void CargarProyectoBasico()
		{
			if(idProyecto== 0)
			{
				MessageBox.Show("Error interno, no hay un proyecto especificado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{

			}

		}
		private void CargarProyectoDetallado()
		{
			if (idProyecto == 0)
			{
				MessageBox.Show("Error interno, no hay un proyecto especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ProyectoNegocios proyectoNegocios = new();
				Proyecto proyectoTemporal = proyectoNegocios.ObtenerProyecto(idProyecto);
				txtEstado.Text = proyectoTemporal.Estado;
				
			}

		}
	}
}
