using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class ListaCotizaciones : Form
    {

        public ListaCotizaciones()
        {
            InitializeComponent();
            CargarOfertas();
            CargarCotizaciones();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool Resultado = ValidarDatos();
            if (Resultado)
            {
                Cotizacion cotizacion = new Cotizacion();
                cotizacion.Cliente = txtCliente.Text;
                cotizacion.Titulo = txtTitulo.Text;
                cotizacion.Descripcion = txtDescripcion.Text;

                cotizacion.Provincia = cbProvincia.Text;
                cotizacion.Canton = txtDireccion.Text;
                cotizacion.EsPublico = ckPuPri.Checked;
                cotizacion.Trabajadores = int.Parse(numTrabajadores.Value.ToString());
                cotizacion.DiasLaborales = float.Parse(numDiasLaborales.Value.ToString());
                cotizacion.MontoMO = float.Parse(numMO.Value.ToString());
                cotizacion.MontoKM = float.Parse(numKilometraje.Value.ToString());
                cotizacion.MontoMaterial = float.Parse(numMaterial.Value.ToString());
                cotizacion.MontoProductos = float.Parse(numProductos.Value.ToString());
                cotizacion.MontoViaticos = float.Parse(numViaticos.Value.ToString());
                cotizacion.Total = float.Parse(numTotal.Value.ToString());
                cotizacion.OfertaId = int.Parse(cbOferta.Text.ToString());
                cotizacion.Categoria = comboBoxCategoria.Text;

                cotizacion.Autor = Temporal.UsuarioActivo.Nombre;
                cotizacion.Creación = DateTime.Now;
                cotizacion.UltimaModificacion = DateTime.Now;
                cotizacion.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                cotizacion.RutaArchivo = "";
                var result = CotizacionNegocio.Add(cotizacion);
                MessageBox.Show("Cotización ingresada\nNúmero de cotizacion: " + result.CotizacionId, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                CargarCotizaciones();
            }
        }

        private bool ValidarDatos()
        {
            //  throw new NotImplementedException();
            return true;
        }

        private void CargarOfertas()
        {
            cbOferta.Items.Clear();
            OfertaNegocio ofertaNegocio = new OfertaNegocio();
            Dictionary<int, string> Ofertas = ofertaNegocio.DiccionarioOfertas();
            foreach (var item in Ofertas)
            {
                cbOferta.Items.Add(item.Key);
            }
        }

        private void CargarCotizaciones()
        {
            dataGridViewCotizaciones.Columns.Clear();

            DataTable _dt = new();
            _dt.Columns.Add("ID");
            _dt.Columns.Add("Cliente");
            _dt.Columns.Add("Titulo");
            _dt.Columns.Add("Autor");
            _dt.Columns.Add("Tipo");
            _dt.Columns.Add("Categoria");
            _dt.Columns.Add("Fecha");
            _dt.Columns.Add("Monto");

            var cotizaciones = CotizacionNegocio.UltimasCotizaciones(40);

            foreach (var i in cotizaciones)
            {

                _dt.Rows.Add(
                    i.CotizacionId,
                    i.Cliente,
                    i.Titulo,
                    i.Autor,
                    (i.EsPublico) ? "PUblico" : "Privado",
                    i.Categoria,
                    i.Creación.ToShortDateString(),
                    i.Total.ToString()
                    );
            }

            // Add button to See
            DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
            botonVer.HeaderText = "Ver";
            botonVer.Text = "Ver";
            botonVer.Name = "btnVer";
            botonVer.UseColumnTextForButtonValue = true;
            dataGridViewCotizaciones.Columns.Add(botonVer);

            DataGridViewButtonColumn _btnEditar = new();
            _btnEditar.HeaderText = "Editar";
            _btnEditar.Text = "Editar";
            _btnEditar.Name = "btnEditar";
            _btnEditar.UseColumnTextForButtonValue = true;

            dataGridViewCotizaciones.Columns.Add(_btnEditar);

            dataGridViewCotizaciones.DataSource = _dt;
        }

        private void agToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new AgregarOferta();
            agregarOferta.ShowDialog();
            CargarOfertas();
        }

        private void dataGridViewCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var datoid = (dataGridViewCotizaciones.Rows[e.RowIndex].Cells[2].Value.ToString());
                // Ver
                if (e.ColumnIndex == 0)
                {
                    Temporal.CotizacioId = int.Parse(datoid);
                    VerCotizacion verCotizacion = new VerCotizacion();
                    verCotizacion.Show();
                }
                // Editar
                else if (e.ColumnIndex == 1)
                {
                    Temporal.CotizacioId = int.Parse(datoid);
                    EditarCotizacion editarCotizacion = new();
                    editarCotizacion.ShowDialog();
                }

            }
            catch (Exception)
            {


            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaInforme listaInforme = new ListaInforme();
            listaInforme.Show();
        }

        private void ckPuPri_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPuPri.Checked)
            {
                ckPuPri.Text = "Es Publico";
            }
            else
            {
                ckPuPri.Text = "Es Privado";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtCliente.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbProvincia.SelectedIndex = -1;
            txtDireccion.Text = string.Empty;
            ckPuPri.Checked = false;
            ckPuPri.Text = "Es Público";
            numTrabajadores.Value = 0;
            numDiasLaborales.Value = 0;
            numMO.Value = 0;
            numKilometraje.Value = 0;
            numMaterial.Value = 0;
            numProductos.Value = 0;
            numViaticos.Value = 0;
            numImprevisto.Value = 0;
            numTotal.Value = 0;
            cbOferta.SelectedIndex = -1;
            comboBoxCategoria.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Oferta = (!string.IsNullOrEmpty(txtBuscarOferta.Text)) ? int.Parse(txtBuscarOferta.Text) : 0;
                string Cliente = (!string.IsNullOrEmpty(txtBuscarCLiente.Text)) ? txtBuscarCLiente.Text : string.Empty;
                var resultados = CotizacionNegocio.Buscar(Oferta, Cliente);


                dataGridViewCotizaciones.Columns.Clear();

                DataTable _dt = new();
                _dt.Columns.Add("ID");
                _dt.Columns.Add("Cliente");
                _dt.Columns.Add("Titulo");
                _dt.Columns.Add("Autor");
                _dt.Columns.Add("Tipo");
                _dt.Columns.Add("Categoria");
                _dt.Columns.Add("Fecha");
                _dt.Columns.Add("Monto");

                var cotizaciones = CotizacionNegocio.UltimasCotizaciones(40);

                foreach (var i in resultados)
                {

                    _dt.Rows.Add(
                        i.CotizacionId,
                        i.Cliente,
                        i.Titulo,
                        i.Autor,
                        (i.EsPublico) ? "PUblico" : "Privado",
                        i.Categoria,
                        i.Creación.ToShortDateString(),
                        i.Total.ToString()
                        );
                }

                // Add button to See
                DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
                botonVer.HeaderText = "Ver";
                botonVer.Text = "Ver";
                botonVer.Name = "btnVer";
                botonVer.UseColumnTextForButtonValue = true;
                dataGridViewCotizaciones.Columns.Add(botonVer);

                DataGridViewButtonColumn _btnEditar = new();
                _btnEditar.HeaderText = "Editar";
                _btnEditar.Text = "Editar";
                _btnEditar.Name = "btnEditar";
                _btnEditar.UseColumnTextForButtonValue = true;

                dataGridViewCotizaciones.Columns.Add(_btnEditar);

                dataGridViewCotizaciones.DataSource = _dt;
            }
            catch (FormatException f)
            {
                MessageBox.Show("Verifique los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBuscarLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarCLiente.Text = string.Empty;
            txtBuscarOferta.Text = string.Empty;
            CargarCotizaciones();
        }
    }
}
