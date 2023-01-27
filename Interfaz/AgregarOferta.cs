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
	public partial class AgregarOferta : Form
	{
		private List<Usuario> usuarios= new List<Usuario>();
		public AgregarOferta()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void AgregarOferta_Load(object sender, EventArgs e)
		{
			CargarEncargados();
		}
		private async Task CargarEncargados()
		{
			try
			{
				UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
				usuarios = await UsuarioNegocio.ListarVendedoresAsync();
				foreach (var item in usuarios)
				{
					cbEncargado.Items.Add(item.Nombre);
				}
			}catch(Exception ex) { 
				MessageBox.Show($"Error Interno: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			bool valido = ValidarCampos();
			if (valido)
			{
				Oferta ofertaTemporal = new Oferta();
				ofertaTemporal.AutorPrespuesto = Temporal.UsuarioActivo.Nombre;
				ofertaTemporal.UltimaModificacion = DateTime.Now;
				ofertaTemporal.Fecha = dateTimePickerFecha.Value;
				ofertaTemporal.Sellador = checkBoxSellador.Checked;
				ofertaTemporal.Asfalto = checkBoxAsfalto.Checked;
				ofertaTemporal.Base = checkBoxBase.Checked;
				ofertaTemporal.SubBase = checkBoxSubbase.Checked;
				ofertaTemporal.Excavacion= checkBoxExcavacion.Checked;
				ofertaTemporal.Cliente = txtCliente.Text;
				ofertaTemporal.Monto = float.Parse(txtMonto.Text);
				ofertaTemporal.Notas = txtNotas.Text;
				ofertaTemporal.Observaciones = txtObservaciones.Text;
				ofertaTemporal.UsuarioId = (from i in usuarios
											where i.Nombre == cbEncargado.Text
											select i.UsuarioId).FirstOrDefault();
				ofertaTemporal.EncargadoCotizador = txtEncargado.Text;
				OfertaNegocio negocioOferta = new();
				bool Resultado = negocioOferta.CrearOferta(ofertaTemporal, out int idOferta);
				if (Resultado)
				{
					MessageBox.Show($"Oferta Guardada exitosamente \nOferta Id= {idOferta}\nCliente= {ofertaTemporal.Cliente}\nMonto= {ofertaTemporal.Monto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show($"Error interno, no fue posible guardar la informacion", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		private bool ValidarCampos()
		{
			try
			{
				if (string.IsNullOrEmpty(txtCliente.Text))
				{
					MessageBox.Show($"Nombre del Cliente no digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return  false;
				}
				int.TryParse(txtMonto.Text,out int val);
				if(val == 0)
				{
					MessageBox.Show($"Verifique el monto digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				if (string.IsNullOrEmpty(txtNotas.Text))
				{
					MessageBox.Show("No digito notas sobre la cotizacion","Adventencia",MessageBoxButtons.OK);
				}
				if (string.IsNullOrEmpty(txtObservaciones.Text))
				{
					MessageBox.Show("Descripcion del trabajo no mencionanda", "Adventencia", MessageBoxButtons.OK);
				}
				if (string.IsNullOrEmpty(cbEncargado.Text))
				{
					MessageBox.Show($"No selecciono un vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				if (string.IsNullOrEmpty(txtEncargado.Text))
				{
					MessageBox.Show($"No ingreso un encargado de la realizacion de la cotizacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				return true;
			}catch(Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return false;
			}
		}
	}
}
