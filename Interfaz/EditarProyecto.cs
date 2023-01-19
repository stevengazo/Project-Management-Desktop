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
	public partial class EditarProyecto : Form
	{
		public int ProyectoId { get; set; } = 0;
		public EditarProyecto()
		{
			InitializeComponent();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			var Resultado = MessageBox.Show("¿Deseas borrar este proyecto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		}

		private void EditarProyecto_Load(object sender, EventArgs e)
		{
			if(ProyectoId!=0)
			{
				ProyectoNegocios proyectoNegocios = new();
				var proyecto = proyectoNegocios.ObtenerProyecto(ProyectoId);
				txtNumeroProyecto.Text = proyecto.ProyectoId.ToString();
				// vendedor
				txtRazonSocial.Text = proyecto.Cliente;
				dtpOC.Value = proyecto.FechaOC;
				txtContacto.Text = proyecto.Cliente;
				// oferta
				txtMonto.Text = proyecto.Monto.ToString();
				numericUpDownPorcentaje.Value = proyecto.PorcentajeAnticipo;
				txtNumeroFactura.Text = proyecto.FacturaAnticipoId;
				txtTarea.Text = proyecto.TareaId.ToString();
				txtUbicacion.Text = proyecto.Ubicacion;
				dtpInicio.Value = proyecto.FechaInicio;
				dtpFinalizacion.Value = proyecto.FechaFinal;
				cbEstado.Text = proyecto.Estado;
			}
			else
			{
				MessageBox.Show("Error interno", "Advertencia");
			}

		}
	}
}
