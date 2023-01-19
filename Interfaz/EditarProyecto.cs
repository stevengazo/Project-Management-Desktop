using Modelos;
using Negocio;
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
		private List<Usuario> Vendedores = new();
		private Dictionary<int, string> Ofertas = new();

		public int ProyectoId { get; set; } = 0;
		public EditarProyecto()
		{
			InitializeComponent();
		}


		private void CargarVendedores()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = usuarioNegocio.ListarVendedores();
			if (Vendedores.Count > 0)
			{
				cbVendedores.Items.Clear();
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}

		private void cargarOfertas()
		{
			try
			{
				OfertaNegocio ofertaNegocio = new();
				Ofertas = ofertaNegocio.DiccionarioOfertas();
				if (Ofertas != null)
				{
				 comboBoxOfertas.Items.Clear();
					foreach (var item in Ofertas)
					{
						comboBoxOfertas.Items.Add($"{item.Key}-{item.Value}");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void btnBorrar_Click(object sender, EventArgs e)
		{
			var Resultado = MessageBox.Show("¿Deseas borrar este proyecto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(Resultado == DialogResult.Yes)
			{
				ProyectoNegocios proyectoNegocios = new ProyectoNegocios();
				throw new NotImplementedException();
			}
		}

		private void EditarProyecto_Load(object sender, EventArgs e)
		{
			cargarOfertas();
			CargarVendedores();
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
