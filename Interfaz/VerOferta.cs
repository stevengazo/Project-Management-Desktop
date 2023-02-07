using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelos;
using System.Globalization;

namespace Interfaz
{
	public partial class VerOferta : Form
	{
		public int idOferta { get; set; }
		public VerOferta()
		{
			InitializeComponent();
		}

		private void VerOferta_Load(object sender, EventArgs e)
		{
			OfertaNegocio ofertaNegocio = new();
			var oferta = ofertaNegocio.ObtenerOferta(idOferta);
			if(oferta != null )
			{
				txtCliente.Text = oferta.Cliente;
				txtFecha.Text = oferta.Fecha.ToLongDateString();
				checkBoxSellador.Checked = oferta.Sellador;
				checkBoxAsfalto.Checked = oferta.Asfalto;
				checkBoxBase.Checked = oferta.Base;
				checkBoxSubbase.Checked = oferta.SubBase;
				checkBoxExcavacion.Checked = oferta.Excavacion;
				txtMonto.Text = oferta.Monto.ToString("C", CultureInfo.CurrentCulture);
				txtNotas.Text = oferta.Notas;
				txtObservaciones.Text = oferta.Observaciones;
				textEncargado.Text = oferta.Encargado.Nombre;
				txtCotizador.Text = oferta.EncargadoCotizador;
			}
			else
			{
				MessageBox.Show("Error no es posible mostrar la oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
	}
}
