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
				txtNumeroProyecto.Text = proyectoTemporal.ProyectoId.ToString();
				txtEstado.Text = proyectoTemporal.Estado;
				txtVendedor.Text = proyectoTemporal.Vendedor.Nombre;
			//	txtRazonSocial.Text = proyectoTemporal.
				txtOC.Text = proyectoTemporal.FechaOC.ToLongDateString();
				txtContacto.Text = proyectoTemporal.Contacto;
				txtOferta.Text = proyectoTemporal.OfertaId;
				txtMontoProyecto.Text = proyectoTemporal.Monto.ToString();
				txtPorcentaje.Text = $"{proyectoTemporal.PorcentajeAnticipo}%";
				txtNumeroFacturaAnticipo.Text = proyectoTemporal.FacturaAnticipoId;
				txtNumeroTarea.Text = proyectoTemporal.TareaId.ToString();
				txtUbicacion.Text = proyectoTemporal.Ubicacion;
				txtFechaInicio.Text = proyectoTemporal.FechaInicio.ToLongDateString() ;
				txtFechaFinal.Text = proyectoTemporal.FechaFinal.ToLongDateString();
				
			}

		}
	}
}
