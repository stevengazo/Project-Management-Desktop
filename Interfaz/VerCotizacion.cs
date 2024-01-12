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
    public partial class VerCotizacion : Form
    {
        private Cotizacion d = new();
        public VerCotizacion()
        {
            InitializeComponent();
            d = CotizacionNegocio.Get(Temporal.CotizacioId);
            if (d != null)
            {
                txtCliente.Text = d.Cliente;
                txtTitulo.Text = d.Titulo;
                txtDireccion.Text = d.Canton;
                txtDescripcion.Text = d.Descripcion;
                txtProvincia.Text = d.Provincia;
                txtTipo.Text = (d.EsPublico) ? "Es publico" : "es privado";
                txtTrabajadores.Text = d.Trabajadores.ToString();
                txtDias.Text = d.DiasLaborales.ToString();
                txtMO.Text = d.MontoMO.ToString();
                txtKM.Text = d.MontoKM.ToString();
                txtMaterial.Text = d.MontoMaterial.ToString();
                txtProductos.Text = d.MontoProductos.ToString();
                txtViaticos.Text = d.MontoViaticos.ToString();
                txtImprevistos.Text = d.Imprevisto.ToString();
                txtTotal.Text = d.Total.ToString();
                txtNumeroOferta.Text = d.OfertaId.ToString();
                txtTipoCotizacion.Text = d.Categoria;

            }

        }
    }
}
