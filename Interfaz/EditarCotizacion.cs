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
    public partial class EditarCotizacion : Form
    {
        private Cotizacion Cotizacion { get; set; }
        public EditarCotizacion()
        {
            InitializeComponent();
            OnInitialized();
        }

        private void OnInitialized()
        {

            OfertaNegocio ofertaNegocio = new OfertaNegocio();
            var dic = ofertaNegocio.DiccionarioOfertas(30);

            foreach (var item in dic)
            {
                cbOferta.Items.Add(item.Key);
            }


            Cotizacion = CotizacionNegocio.Get(Temporal.CotizacioId);
            if (Cotizacion != null)
            {
                txtCliente.Text = Cotizacion.Cliente;
                txtDescripcion.Text = Cotizacion.Descripcion;
                txtDireccion.Text = Cotizacion.Canton;
                txtTitulo.Text = Cotizacion.Titulo;
                comboBoxCategoria.Text = Cotizacion.Categoria;
                cbProvincia.Text = Cotizacion.Provincia;
                cbOferta.Text = Cotizacion.OfertaId.ToString();
                numDiasLaborales.Value = (decimal)Cotizacion.DiasLaborales;
                numKilometraje.Value = (decimal)Cotizacion.MontoKM;
                numMaterial.Value = (decimal)Cotizacion.MontoMaterial;
                numMO.Value = (decimal)Cotizacion.MontoMO;
                numProductos.Value = (decimal)Cotizacion.MontoProductos;
                numViaticos.Value = (decimal)Cotizacion.MontoViaticos;
                numTotal.Value = (decimal)Cotizacion.Total;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cotizacion.Cliente = txtCliente.Text;
            Cotizacion.Descripcion = txtDescripcion.Text;
            Cotizacion.Canton = txtDireccion.Text;
            Cotizacion.Titulo = txtTitulo.Text;
            Cotizacion.Categoria =  comboBoxCategoria.Text;
            Cotizacion.Provincia = cbProvincia.Text;
            Cotizacion.OfertaId =  int.Parse(cbOferta.Text);
            Cotizacion.DiasLaborales = int.Parse( numDiasLaborales.Value.ToString());
            Cotizacion.MontoKM = float.Parse( numKilometraje.Value.ToString ());
            Cotizacion.MontoMaterial = float.Parse( numMaterial.Value.ToString());
            Cotizacion.MontoMO = float.Parse( numMO.Value.ToString());
            Cotizacion.MontoProductos = float.Parse( numProductos.Value.ToString());
            Cotizacion.MontoViaticos = float.Parse( numViaticos.Value.ToString());
            Cotizacion.Total = float.Parse( numTotal.Value.ToString());
            Cotizacion.UltimoEditor = Temporal.UsuarioActivo.Nombre;
            Cotizacion.UltimaModificacion = DateTime.Now;
            CotizacionNegocio.Update(Cotizacion);
            MessageBox.Show("Cotizacion actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
