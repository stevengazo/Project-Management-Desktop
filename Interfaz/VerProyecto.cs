using Modelos;
using Negocio;
using Negocios;
using System.Data;
using System.Globalization;

namespace Interfaz
{
    public partial class VerProyecto : Form
    {
        public int idProyecto { get; set; } = 0;
        Proyecto proyectoTemporal { get; set; }
        public VerProyecto()
        {
            InitializeComponent();
        }
        private void VerProyecto_Load(object sender, EventArgs e)
        {
            CargarProyectoDetallado();
            CargarInforme();

        }
        private async Task CargarNotas(int id)
        {
            List<Nota> Notas = NotaNegocio.GetNotasByProyecto(id);
            if (Notas.Count > 0)
            {
                dataGridViewComentarios.Columns.Clear();

                DataTable _dt = new();

                _dt.Columns.Add("Titulo");
                _dt.Columns.Add("Autor");
                _dt.Columns.Add("ID");
                foreach (Nota nota in Notas)
                {
                    _dt.Rows.Add(
                            nota.Titulo,
                            nota.Autor,
                            nota.NotaId
                        );
                }
                dataGridViewComentarios.DataSource = _dt;

                DataGridViewButtonColumn botonVer = new();
                botonVer.HeaderText = "Ver";
                botonVer.Text = "Ver";
                botonVer.Name = "btnVerNota";
                botonVer.UseColumnTextForButtonValue = true;
                dataGridViewComentarios.Columns.Add(botonVer);

                DataGridViewButtonColumn botonEditar = new();
                botonEditar.HeaderText = "Editar";
                botonEditar.Text = "Editar";
                botonEditar.Name = "btnEditarNota";
                botonEditar.UseColumnTextForButtonValue = true;
                dataGridViewComentarios.Columns.Add(botonEditar);
            }
        }

        private void CargarProyectoDetallado()
        {
            try
            {
                if (idProyecto == 0)
                {
                    MessageBox.Show("Error interno, no hay un proyecto especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProyectoNegocios proyectoNegocios = new();
                    proyectoTemporal = proyectoNegocios.ObtenerProyecto(idProyecto);
                    this.idProyecto = proyectoTemporal.ProyectoId;
                    CargarNotas(proyectoTemporal.ProyectoId);
                    // Carga Informacion
                    txtNumeroProyecto.Text = $"P-{proyectoTemporal.ProyectoId}";
                    txtCedula.Text = proyectoTemporal.Cedula;
                    txtSector.Text = (proyectoTemporal.EsPublico) ? "Proyecto Sector Publico" : "Proyecto Sector Privado";
                    txtOfertaId.Text = proyectoTemporal.OfertaId;
                    txtOrdenCompra.Text = proyectoTemporal.OrdenCompra;
                    tipocambio.Text = proyectoTemporal.TipoCambio.ToString();
                    txtFechaOC.Text = proyectoTemporal.FechaOC.ToLongDateString();
                    txtTipoMoneda.Text = proyectoTemporal.TipoMoneda;
                    txtMonto.Text = proyectoTemporal.Monto.ToString();
                    txtMontoIVA.Text = proyectoTemporal.MontoIVA.ToString();
                    txtPorcentajeAnticipo.Text = $"{proyectoTemporal.PorcentajeAnticipo}%";
                    txtTipoTrabajo.Text = proyectoTemporal.Tipo;
                    txtDescripcion.Text = proyectoTemporal.Descripcion;
                    txtProvincia.Text = proyectoTemporal.Provincia;
                    txtUbicacion.Text = proyectoTemporal.Ubicacion;
                    txtTarea.Text = proyectoTemporal.TareaId.ToString();
                    txtVendedor.Text = proyectoTemporal.Vendedor.Nombre;
                    txtEstado.Text = proyectoTemporal.Estado;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno: {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloNota.Text) || string.IsNullOrEmpty(txtDescripcionNota.Text))
            {
                MessageBox.Show("Verifique los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nota nota = new Nota()
                {
                    Titulo = txtTituloNota.Text,
                    Descripcion = txtDescripcionNota.Text,
                    Autor = Temporal.UsuarioActivo.Nombre,
                    ProyectoId = this.idProyecto,
                    UltimoEditor = Temporal.UsuarioActivo.Nombre,
                    Creacion = DateTime.Now,
                    UltimaModificacion = DateTime.Now
                };

                NotaNegocio.Add(nota);
                MessageBox.Show("Nota Agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTituloNota.Text = string.Empty;
                txtDescripcionNota.Text = string.Empty;
                CargarNotas(this.idProyecto);
            }
        }

        private void dataGridViewComentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idNota = int.Parse(dataGridViewComentarios.Rows[e.RowIndex].Cells[2].Value.ToString());
                // View
                Temporal.NotaId = idNota;
                if (e.ColumnIndex == 3)
                {
                    VerNota verNota = new();
                    verNota.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {
                    // Update
                    EditarNota editarNota = new();
                    editarNota.ShowDialog();
                    CargarNotas(this.idProyecto);
                }
            }
            catch (Exception f)
            {

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void CargarInforme()
        {

            var Informes = InformeNegocio.GetListByProyect(idProyecto);
            if (Informes != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add(" Entrega Maxima");
                dt.Columns.Add(" Finalizacion");
                dt.Columns.Add("Cliente");
                dt.Columns.Add("Proyecto Id");
                dt.Columns.Add("Tipo Trabajo");
                dt.Columns.Add("Técnico");
                dt.Columns.Add("Encargado");
                dt.Columns.Add("Estado");
                dt.Columns.Add("Descripción");
                foreach (var item in Informes)
                {
                    dt.Rows.Add(
                        item.InformeId,
                        item.FechaMaxima.ToLongDateString(),
                        (item.Concluido) ? item.FechaRegistro.ToLongDateString() : "Sin Finalizar",
                        item.Proyecto.Cliente,
                        item.ProyectoId,
                        item.Proyecto.Tipo,
                        (string.IsNullOrEmpty(item.Tecnico)) ? "Sin Dato" : item.Tecnico,
                        (item.Usuario != null) ? item.Usuario.Nombre : "Sin Asignar",
                        item.Estado,
                        item.Descripcion

                        );
                }
                dataGridViewInformes.DataSource = dt;
            }

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de entrada
            string resultado = Microsoft.VisualBasic.Interaction.InputBox("Digite el número de Factura. Advertencia el proyecto se marcará como facturado\n\nRecomendación: ingrese una nota de que este proyecto ya fue facturado", "Ingreso de Factura");
            if (!string.IsNullOrEmpty(resultado))
            {
                var pN = new ProyectoNegocios();
                proyectoTemporal.Finalizado = true;
                proyectoTemporal.Facturado = true;
                proyectoTemporal.Estado = "Finalizado con cobro";
                pN.ActualizarProyecto(proyectoTemporal);
                MessageBox.Show("Factura añadida, proyecto finalizado", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Desea Marcar Este proyecto como finalizado? (Solo debe ser marcado una vez la ejecución)", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                var pN = new ProyectoNegocios();
                proyectoTemporal.Finalizado = true;
                proyectoTemporal.Estado = "Finalizado sin cobro";
                pN.ActualizarProyecto(proyectoTemporal);
                MessageBox.Show("Proyecto marcado como finalizado", "Informacion", MessageBoxButtons.OK);
            }
        }
    }
}
