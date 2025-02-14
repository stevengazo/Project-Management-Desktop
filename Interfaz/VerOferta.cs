﻿using Negocio;
using System.Globalization;

namespace Interfaz
{
    public partial class VerOferta : Form
    {
        #region Properties
        public int idOferta { get; set; }
        #endregion

        #region Constructor
        public VerOferta()
        {
            InitializeComponent();
        }
        #endregion

        #region Loadings
        private void VerOferta_Load(object sender, EventArgs e)
        {
            OfertaNegocio ofertaNegocio = new();
            var oferta = ofertaNegocio.ObtenerOferta(idOferta);
            if (oferta != null)
            {
                txtCliente.Text = oferta.Cliente;
                txtFecha.Text = oferta.Fecha.ToLongDateString();
                checkBoxSellador.Checked = oferta.Sellador;
                checkBoxSellador.Enabled = false;
                checkBoxAsfalto.Checked = oferta.Asfalto;
                checkBoxAsfalto.Enabled = false;
                checkBoxBase.Checked = oferta.Base;
                checkBoxBase.Enabled = false;
                checkBoxSubbase.Checked = oferta.SubBase;
                checkBoxSubbase.Enabled = false;
                checkBoxExcavacion.Checked = oferta.Excavacion;
                checkBoxExcavacion.Enabled = false;
                txtMonto.Text = oferta.Monto.ToString("C", CultureInfo.CurrentCulture);
                txtNotas.Text = oferta.Notas;
                txtObservaciones.Text = oferta.Observaciones;
                textEncargado.Text = oferta.Encargado.Nombre;
                txtCotizador.Text = oferta.EncargadoCotizador;
                ckDemarcacion.Checked = oferta.Demarcado;
                ckDemarcacion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error no es posible mostrar la oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
    }
}
