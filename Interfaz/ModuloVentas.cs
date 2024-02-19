using Microsoft.IdentityModel.Tokens;
using Modelos;
using Negocio;
using Negocios;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interfaz
{
    public partial class ModuloVentas : Form
    {
        private Dictionary<int, string> Ofertas = new();
        private List<Proyecto> proyectos = new();
        private Proyecto ProyectoTemporal = new();
        private List<Usuario> Vendedores = new();
        public ModuloVentas()
        {
            InitializeComponent();
        }

        private void agregarRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarTabla();
            CargarVendedores();
            this.Text = $"Modulo Ventas - Asfaltos - Bienvenido {Temporal.UsuarioActivo.Nombre}";
        }



        private void CargarVendedores()
        {
            UsuarioNegocio usuarioNegocio = new();
            Vendedores = usuarioNegocio.ListarVendedores();
            if (Vendedores.Count > 0)
            {
                foreach (var item in Vendedores)
                {
                    cbVendedores.Items.Add(item.Nombre);
                }
            }
        }
        private async Task CargarTabla(List<Proyecto> proyectosListados = null)
        {
            var proyectosNegocio = new ProyectoNegocios();
            if (proyectosListados != null)
            {
                proyectos = proyectosListados;
            }
            else
            {
#pragma warning disable CS8601 // Posible asignación de referencia nula
                proyectos = await proyectosNegocio.ListaProyectos(idEncargado: Temporal.UsuarioActivo.UsuarioId);
#pragma warning restore CS8601 // Posible asignación de referencia nula
            }
            if (proyectos != null)
            {
                if (proyectos.Count > 0)
                {
                    DataTable _tabla = new();

                    _tabla.Columns.Add("Id Interno");
                    _tabla.Columns.Add("Tarea");
                    _tabla.Columns.Add("Fecha Ingreso");
                    _tabla.Columns.Add("Cliente");
                    _tabla.Columns.Add("Oferta");
                    _tabla.Columns.Add("OC");
                    _tabla.Columns.Add("Tipo Moneda");
                    _tabla.Columns.Add("Monto");
                    _tabla.Columns.Add("IVA");
                    _tabla.Columns.Add("Tipo");
                    _tabla.Columns.Add("Provincia");
                    _tabla.Columns.Add("Estado");



                    foreach (Proyecto i in proyectos)
                    {
                        _tabla.Rows.Add(
                                    i.ProyectoId,
                                    i.TareaId.ToString(),
                                    i.FechaIngreso.ToShortDateString(),
                                    i.Cliente,
                                    i.OfertaId.ToString(),
                                    i.OrdenCompra,
                                    i.TipoMoneda,
                                    i.Monto.ToString(),
                                    i.MontoIVA.ToString(),
                                    i.Provincia,
                                    i.Estado
                            );
                    }
                    dgvProyectos.Columns.Clear();
                    dgvProyectos.DataSource = _tabla;
                    DataGridViewButtonColumn botonVer = new();
                    botonVer.HeaderText = "Ver";
                    botonVer.Text = "Ver";
                    botonVer.Name = "btnVerProyecto";
                    botonVer.UseColumnTextForButtonValue = true;
                    dgvProyectos.Columns.Add(botonVer);


                    DataGridViewButtonColumn botonEditar = new();
                    botonEditar.HeaderText = "Editar";
                    botonEditar.Text = "Editar";
                    botonEditar.Name = "btnEditarProyecto";
                    botonEditar.UseColumnTextForButtonValue = true;
                    dgvProyectos.Columns.Add(botonEditar);
                }
            }
        }


        private void LimpiarDatos()
        {
            txtNombreCliente.Text = string.Empty;
            txtCedula.Text = string.Empty;
            checkBoxPublico.Checked = false;
            numericUpDownOferta.Value = 0;
            txtOrdenCompra.Text = string.Empty;
            dtpOrdenCompra.Value = DateTime.Today;
            cbTipoTrabajo.SelectedIndex = -1;
            numericUpDownMonto.Value = 0;
            numericUpDownMontoIVA.Value = 0;
            numericUpDownPorcentaje.Value = 0;
            cbTipoTrabajo.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
            cbProvincia.SelectedIndex = -1;
            numericUpDownTarea.Value = 0;
            cbVendedores.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuario listarUsuariotmp = new();
            listarUsuariotmp.ShowDialog();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Title = "Exportar a Excel";
                saveFileDialog.Filter = "Excel|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string URLArchivo = saveFileDialog.FileName;
                    var ExcelApp = new Excel.Application();
                    ExcelApp.Workbooks.Add();
                    Excel._Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;
                    worksheet.Cells[1, "A"] = "ID";
                    worksheet.Cells[1, "B"] = "Cliente";
                    worksheet.Cells[1, "C"] = "Cedula";
                    worksheet.Cells[1, "D"] = "Sector";
                    worksheet.Cells[1, "E"] = "Oferta Id";
                    worksheet.Cells[1, "F"] = "Orden de Compra";
                    worksheet.Cells[1, "G"] = "Fecha OC";
                    worksheet.Cells[1, "H"] = "Tipo Moneda";
                    worksheet.Cells[1, "I"] = "Monto";
                    worksheet.Cells[1, "J"] = "IVA";
                    worksheet.Cells[1, "K"] = "Porcentaje de Anticipo";
                    worksheet.Cells[1, "L"] = "Tarea";
                    worksheet.Cells[1, "M"] = "Descripciones";
                    worksheet.Cells[1, "N"] = "Provincia";
                    worksheet.Cells[1, "O"] = "Ubicación";
                    worksheet.Cells[1, "P"] = "Tarea";
                    worksheet.Cells[1, "Q"] = "Vendedor";
                    worksheet.Cells[1, "R"] = "Estado";
                    worksheet.Cells[1, "S"] = "Fecha Ingreso";
                    worksheet.Cells[1, "T"] = "Creado Por";
                    worksheet.Cells[1, "U"] = "Ultima Edición";
                    worksheet.Cells[1, "V"] = "Ultimo Editor";

                    int contador = 2;
                    foreach (Proyecto item in proyectos)
                    {
                        worksheet.Cells[contador, 1] = item.ProyectoId.ToString(); // id
                        worksheet.Cells[contador, 2] = item.Cliente; // cLIENTE
                        worksheet.Cells[contador, 3] = item.Cedula.ToLower(); // CEDULA
                        worksheet.Cells[contador, 4] = (!item.EsPublico) ? "Privado" : "Público"; // SECTOR
                        worksheet.Cells[contador, 5] = item.OfertaId.ToString(); // OFERTA ID
                        worksheet.Cells[contador, 6] = item.OrdenCompra; // ORDEN COMPRA
                        worksheet.Cells[contador, 7] = item.FechaOC.ToShortDateString(); // FECHA ORDEN COMPRA
                        worksheet.Cells[contador, 8] = item.TipoMoneda; // TIPO MONEDA
                        worksheet.Cells[contador, 9] = item.Monto.ToString(); // MONTO
                        worksheet.Cells[contador, 10] = item.MontoIVA.ToString(); // MONTO IVA
                        worksheet.Cells[contador, 11] = item.PorcentajeAnticipo.ToString(); // PORCENTAJE ANTICIPO
                        worksheet.Cells[contador, 12] = item.TareaId.ToString(); // TAREA
                        worksheet.Cells[contador, 13] = item.Descripcion.ToLower(); // DESCRIPCIONES
                        worksheet.Cells[contador, 14] = item.Provincia; // PROVINCIA
                        worksheet.Cells[contador, 15] = item.Ubicacion.ToLower(); // Ubicación
                        worksheet.Cells[contador, 16] = item.TareaId.ToString(); // Tarea
                        worksheet.Cells[contador, 17] = item.Vendedor.Nombre; // Vendedor
                        worksheet.Cells[contador, 18] = item.Estado; // Estado
                        worksheet.Cells[contador, 19] = item.FechaIngreso.ToShortDateString(); // Fecha Ingreso
                        worksheet.Cells[contador, 20] = item.Autor; // Creado Por
                        worksheet.Cells[contador, 21] = item.UltimaEdicion.ToShortDateString(); // Ultima Edicion
                        worksheet.Cells[contador, 22] = item.UltimoEditor; // Ultimo Editor
                        contador++;
                    }
                    ExcelApp.ActiveWorkbook.SaveAs(URLArchivo, Excel.XlFileFormat.xlWorkbookDefault);
                    ExcelApp.ActiveWorkbook.Close();
                    ExcelApp.Quit();
                    MessageBox.Show("Documento Generado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool estado = ValidarCampos();
                if (estado)
                {

                    Proyecto proyectoNuevo = new Proyecto();
                    // Datos Proyecto

                    proyectoNuevo.Cliente = txtNombreCliente.Text;
                    proyectoNuevo.Cedula = txtCedula.Text;
                    proyectoNuevo.EsPublico = checkBoxPublico.Checked;
                    proyectoNuevo.OfertaId = numericUpDownOferta.Value.ToString();
                    proyectoNuevo.OrdenCompra = txtOrdenCompra.Text;
                    proyectoNuevo.FechaOC = dtpOrdenCompra.Value;
                    proyectoNuevo.TipoMoneda = comboBoxTipoMoneda.Text;
                    proyectoNuevo.TipoCambio = (float)numericUpDowntipoCambio.Value;
                    proyectoNuevo.Monto = (float)numericUpDownMonto.Value;
                    proyectoNuevo.MontoIVA = (float)numericUpDownMontoIVA.Value;
                    proyectoNuevo.PorcentajeAnticipo = (int)numericUpDownPorcentaje.Value;
                    proyectoNuevo.Tipo = cbTipoTrabajo.Text;
                    proyectoNuevo.Descripcion = txtDescripcion.Text;
                    proyectoNuevo.Provincia = cbProvincia.Text;
                    proyectoNuevo.Ubicacion = txtUbicacion.Text;
                    proyectoNuevo.TareaId = (int)numericUpDownTarea.Value;
                    proyectoNuevo.Vendedor = null;
                    proyectoNuevo.UsuarioId = (from i in Vendedores
                                               where i.Nombre == cbVendedores.Text
                                               select i.UsuarioId).FirstOrDefault();
                    proyectoNuevo.Factura = string.Empty;
                    proyectoNuevo.Estado = cbEstado.Text;
                    proyectoNuevo.Finalizado = false;

                    // Metadatos
                    proyectoNuevo.Enable = true;
                    proyectoNuevo.Autor = Temporal.UsuarioActivo.Nombre;
                    proyectoNuevo.FechaIngreso = DateTime.Today;
                    proyectoNuevo.UltimaEdicion = DateTime.Today;
                    proyectoNuevo.UltimoEditor = Temporal.UsuarioActivo.Nombre;

                    ProyectoNegocios proyectoNegocios = new();
                    var resultado = proyectoNegocios.CrearProyecto(proyectoNuevo, out int idProyecto);
                    if (resultado)
                    {
                        MessageBox.Show($"Proyecto agregado. Id: {idProyecto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                        CargarTabla();
                    }
                    else
                    {
                        MessageBox.Show($"Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }
        private void SetBackLabels()
        {


        }
        private bool ValidarCampos()
        {
            try
            {
                SetBackLabels();

                var VendedorSeleccionado = cbVendedores.Text;
                // Vendedor
                if (string.IsNullOrEmpty(cbVendedores.Text))
                {
                    lblVendedor.ForeColor = Color.Red;
                    MessageBox.Show("No Seleccionó un vendedor", "Advertencia: Validación Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // Razón Social
                if (string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    lblRazon.ForeColor = Color.Red;
                    MessageBox.Show("No indicó una razón social", "Advertencia: Validación de Razón Social", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                /// Porcentaje Anticipo
                if (numericUpDownPorcentaje.Value < 0)
                {
                    lblPorcentaje.ForeColor = Color.Red;
                    MessageBox.Show("El porcentaje de anticipo no puede ser negativo.", "Advertencia: Validación Porcentaje de Anticipo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                // Ubicacion
                if (string.IsNullOrEmpty(txtUbicacion.Text))
                {
                    var response = MessageBox.Show("No indico la ubicación del proyecto \n¿Desea continuar?", "Advertencia: Validación de Ubicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (response == DialogResult.Yes)
                    {
                        txtUbicacion.Text = "No se indica la ubicación del proyecto";

                    }
                    else
                    {
                        return false;
                    }
                }
                // Estado
                if (string.IsNullOrEmpty(cbEstado.Text))
                {
                    lblEstado.ForeColor = Color.Red;
                    var response = MessageBox.Show("No indico el estado del proyecto \n¿Desea continuar?", "Advertencia: Estado del proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (response == DialogResult.Yes)
                    {
                        cbEstado.Text = "Pendiente de Ejecución";
                    }
                    else
                    {
                        return false;
                    }
                }
                SetBackLabels();
                return true;
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno {f.Message}", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListarUsuario listarUsuariousuarios = new();
            listarUsuariousuarios.ShowDialog();
        }
        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new();
            agregarUsuario.ShowDialog();
        }
        private void verCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarOferta listarOferta = new();
            listarOferta.ShowDialog();

        }
        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {
                    VerProyecto verProyecto = new();
                    var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    verProyecto.idProyecto = id;
                    verProyecto.ShowDialog();
                }
                else
                if (e.ColumnIndex == 13)
                {
                    var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EditarProyecto editarProyecto = new();
                    editarProyecto.ProyectoId = id;
                    editarProyecto.ShowDialog();
                    CargarTabla();
                }
                else
                {

                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno: {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void agregarCotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new();
            agregarOferta.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtClienteBuscar.Text) && !string.IsNullOrEmpty(txtNumeroPBuscar.Text))
                {
                    int.TryParse(txtNumeroPBuscar.Text, out int idProyecto);
                    var proyectosFiltrados = (from p in proyectos
                                              where p.Cliente.ToUpper().Contains(txtClienteBuscar.Text.ToUpper()) && p.ProyectoId == idProyecto
                                              select p).ToList();
                    if (proyectosFiltrados.Count > 0)
                    {
                        CargarTabla(proyectosFiltrados);
                    }
                    else
                    {
                        MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (!string.IsNullOrEmpty(txtClienteBuscar.Text))
                {
                    var proyectosFiltrados = (from p in proyectos
                                              where p.Cliente.ToUpper().Contains(txtClienteBuscar.Text.ToUpper())
                                              select p).ToList();
                    if (proyectosFiltrados.Count > 0)
                    {
                        CargarTabla(proyectosFiltrados);
                    }
                    else
                    {
                        MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (!string.IsNullOrEmpty(txtNumeroPBuscar.Text))
                {
                    int.TryParse(txtNumeroPBuscar.Text, out int idProyecto);
                    var proyectosFiltrados = (from p in proyectos
                                              where p.ProyectoId == idProyecto
                                              select p).ToList();
                    if (proyectosFiltrados.Count > 0)
                    {
                        CargarTabla(proyectosFiltrados);
                    }
                    else
                    {
                        MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                txtNumeroPBuscar.Text = string.Empty;
                txtClienteBuscar.Text = string.Empty;
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno {f.Message}", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            txtNumeroPBuscar.Text = string.Empty;
            txtClienteBuscar.Text = string.Empty;
            CargarTabla();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {

        }
    }
}