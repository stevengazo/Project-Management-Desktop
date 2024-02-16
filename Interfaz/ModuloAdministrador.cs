using Modelos;
using Negocio;
using Negocios;
using System.Data;
using System.Globalization;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interfaz
{
    public partial class ModuloAdministrador : Form
    {
        #region Propiedades
        private Thread Proyectos;
        private Thread Exportado;

        private List<Usuario> Vendedores = new();
        private List<Proyecto> proyectos = new();
        private List<Cliente> clientes = new();
        private Dictionary<int, string> Ofertas = new();
        #endregion

        #region Constructor
        public ModuloAdministrador()
        {
            InitializeComponent();
            Carga();
        }
        #endregion

        #region Eventos

        public async void Carga()
        {
            await CargarVendedoresAsync();
            await CargarTablaAsync();
        }

        private void CargarClientes()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Muestra la lista de Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuario listarUsuario = new();
            listarUsuario.ShowDialog();
            CargarVendedoresAsync();
        }

        /// <summary>
        /// Agrega un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new();
            agregarUsuario.ShowDialog();
            CargarVendedoresAsync();
        }

        /// <summary>
        /// Carga la lista de Vendedores en el combobox
        /// </summary>
        /// <returns></returns>
        private async Task CargarVendedoresAsync()
        {
            UsuarioNegocio usuarioNegocio = new();
            Vendedores = await usuarioNegocio.ListarVendedoresAsync();
            if (Vendedores.Count > 0)
            {
                cbVendedores.Items.Clear();
                foreach (var item in Vendedores)
                {
                    cbVendedores.Items.Add(item.Nombre);
                }
            }
        }

        /// <summary>
        /// Carga la información de la tabla
        /// </summary>
        /// <param name="proyectosFiltrados"></param>
        /// <returns></returns>
        /// 
        private async Task CargarTablaAsync(List<Proyecto>? proyectosFiltrados = null)
        {
            if (Proyectos == null || Proyectos.ThreadState == ThreadState.Stopped)
            {
                Proyectos = new Thread(new ThreadStart(async () =>
                {

                    if (proyectosFiltrados != null)
                    {
                        proyectos = proyectosFiltrados;
                    }
                    else
                    {
                        var proyectosNegocio = new ProyectoNegocios();
                        proyectos = await proyectosNegocio.ListarProyectoAsync();
                    }
                    if (proyectos.Count > 0)
                    {
                        dgvProyectos.Invoke(new Action(() =>
                        {
                            dgvProyectos.Columns.Clear();
                            DataTable _tabla = new();
                            _tabla.Columns.Add("Id Interno");
                            _tabla.Columns.Add("Tarea");
                            _tabla.Columns.Add("Vendedor");
                            _tabla.Columns.Add("Cliente");
                            _tabla.Columns.Add("Cedula");
                            _tabla.Columns.Add("Fecha Ingreso");
                            _tabla.Columns.Add("Tipo");
                            _tabla.Columns.Add("Ubicación");
                            _tabla.Columns.Add("Orden Compra");
                            _tabla.Columns.Add("Oferta Id");
                            _tabla.Columns.Add("Monto");
                            _tabla.Columns.Add("Moneda");
                            _tabla.Columns.Add("Estado");


                            foreach (Proyecto i in proyectos)
                            {
                                _tabla.Rows.Add(
                                    i.ProyectoId,
                                    i.TareaId.ToString(),
                                    i.Vendedor.Nombre,
                                    i.Cliente,
                                    i.Cedula,
                                    i.FechaIngreso.ToShortDateString(),
                                    i.Tipo,
                                    i.Provincia,
                                    i.OrdenCompra,
                                    i.OfertaId.ToString(),
                                    i.Monto.ToString(),
                                    i.TipoMoneda,
                                    i.Estado
                                    );
                            }
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
                            dgvProyectos.DataSource = _tabla;
                        }));

                    }
                }));
                Proyectos.Start();
            }
        }

        /// <summary>
        /// Opciones de seleccion de botones en grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    VerProyecto verProyecto = new();
                    var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    verProyecto.idProyecto = id;
                    verProyecto.Show();
                }
                else if (e.ColumnIndex == 1)
                {
                    var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    EditarProyecto editarProyecto = new();
                    editarProyecto.ProyectoId = id;
                    editarProyecto.ShowDialog();
                    await CargarTablaAsync();
                }
                else
                {

                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno: {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Evento de Carga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModuloAdministrador_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Muestra la lista de ofertas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void listarOfertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarOferta listarOferta = new();
            listarOferta.ShowDialog();
        }


        private async void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new();
            agregarOferta.ShowDialog();
        }
        private void ExportadoExcel()
        {
            try
            {


                saveFileDialog1.Title = "Exportar a Excel";
                saveFileDialog1.Filter = "Excel|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string URLArchivo = saveFileDialog1.FileName;
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
                    MessageBox.Show("Documento Generado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// Exporta a Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Exportado == null)
            {
                Exportado = new Thread(ExportadoExcel);
                Exportado.SetApartmentState(ApartmentState.STA);
                Exportado.Start();
            }
            else
            {
                if(Exportado.ThreadState == ThreadState.Running)
                {
                    MessageBox.Show("Exportando datos...", "Informacion");
                }
                else
                {
                    Exportado = new Thread(ExportadoExcel);
                    Exportado.SetApartmentState(ApartmentState.STA);
                    Exportado.Start();
                }
            }
            
        }


        /// <summary>
        /// Agrega un nuevo proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoNegocios proyectoNegocios = new ProyectoNegocios();
                bool Resultado = ValidarCampos();
                if (Resultado)
                {
                    Proyecto proyectoTemporal = new Proyecto();
                    proyectoTemporal.OrdenCompra = txtOrdenCompra.Text;
                    proyectoTemporal.FechaOC = dtpOrdenCompra.Value;
                    proyectoTemporal.EsPublico = checkBoxPublico.Checked;
                    proyectoTemporal.Monto = (float)numericUpDownMonto.Value;
                    proyectoTemporal.FechaIngreso = DateTime.Now;
                    proyectoTemporal.MontoIVA = (int)numericUpDownMontoIVA.Value;
                    proyectoTemporal.Ubicacion = txtUbicacion.Text;
                    proyectoTemporal.Cedula = txtCedula.Text;
                    proyectoTemporal.TareaId = (int)numericUpDownTarea.Value;
                    proyectoTemporal.TipoCambio = (float) numericUpDownTipoCambio.Value;
                    proyectoTemporal.Tipo = cbTipoTrabajo.Text;
                    proyectoTemporal.Descripcion = txtDescripcion.Text.ToLower();
                    proyectoTemporal.TipoMoneda = comboBoxTipoMoneda.Text;
                    proyectoTemporal.Provincia = cbProvincia.Text;
                    proyectoTemporal.Estado = cbEstado.Text;
                    proyectoTemporal.UsuarioId = (from i in Vendedores
                                                  where i.Nombre == cbVendedores.Text
                                                  select i.UsuarioId).FirstOrDefault();
                    proyectoTemporal.OfertaId = numericUpDownOferta.Value.ToString();
                    proyectoTemporal.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                    proyectoTemporal.Autor = Temporal.UsuarioActivo.Nombre;
                    proyectoTemporal.UltimaEdicion = DateTime.Today;
                    proyectoTemporal.Cliente = txtNombreCliente.Text;
                    proyectoTemporal.Enable = true;
                    var resultado = proyectoNegocios.CrearProyecto(proyectoTemporal, out int idProyecto);
                    if (resultado)
                    {
                        Informe nuevoInforme = new();
                        //nuevoInforme.InformeId = InformeNegocio.LastNumber() + 1;
                        nuevoInforme.Calificacion = 0;
                        nuevoInforme.FechaMaxima = proyectoTemporal.FechaOC.AddDays(10);
                        nuevoInforme.FechaRegistro = DateTime.Today;
                        nuevoInforme.Tecnico = "No Especificado";
                        nuevoInforme.Comentarios = "";
                        nuevoInforme.Concluido = false;
                        nuevoInforme.ProyectoId = idProyecto;
                        nuevoInforme.Descripcion = proyectoTemporal.Tipo;
                        nuevoInforme.Estado = "Pendiente";
                        nuevoInforme.UltimaModificacion = DateTime.Today;
                        nuevoInforme.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                        //nuevoInforme.UsuarioId = 0;

                        InformeNegocio.Add(nuevoInforme);

                        MessageBox.Show($"Proyecto agregado. Id: {idProyecto}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarTablaAsync();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show($"Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                else if (numericUpDownPorcentaje.Value == 0)
                {
                    var response = MessageBox.Show("El porcentaje de anticipo se dejó en 0. ¿Desea continuar?", "Advertencia: Validación Porcentaje Anticipo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (response == DialogResult.No)
                    {
                        return false;
                    }
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
                // Provincia
                if (string.IsNullOrEmpty(cbProvincia.Text))
                {
                    MessageBox.Show("No indico la provincia", "Advertencia: Validación de Provincia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                // Estado
                if (string.IsNullOrEmpty(cbTipoTrabajo.Text))
                {
                    lblEstado.ForeColor = Color.Red;
                    var response = MessageBox.Show("No Indico el tipo de proyecto", "Advertencia: Estado del proyecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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
                Console.WriteLine(f.Message);
                return false;
            }
        }

        private void SetBackLabels()
        {
            lblVendedor.ForeColor = Color.White;
            lblRazon.ForeColor = Color.White;
            lblOferta.ForeColor = Color.White;
            lblMonto.ForeColor = Color.White;
            lblPorcentaje.ForeColor = Color.White;
            lblTarea.ForeColor = Color.White;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacte al Encargado para obtener la documentación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombreCliente.Text = string.Empty;
            txtCedula.Text = string.Empty;
            checkBoxPublico.Checked = false;
            numericUpDownOferta.Value = 0;
            txtOrdenCompra.Text = string.Empty;
            dtpOrdenCompra.Value = DateTime.Today;
            comboBoxTipoMoneda.SelectedIndex = -1;
            numericUpDownMonto.Value = 0;
            numericUpDownMontoIVA.Value = 0;
            numericUpDownPorcentaje.Value = 0;
            cbTipoTrabajo.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
            cbProvincia.SelectedIndex = -1;
            txtUbicacion.Text = string.Empty;
            numericUpDownTarea.Value = 0;
            cbVendedores.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreBuscar.Text) && !string.IsNullOrEmpty(txtNumeroProyectoBuscar.Text))
            {
                int.TryParse(txtNumeroProyectoBuscar.Text, out int idProyecto);
                var proyectosFiltrados = (from p in proyectos
                                          where p.Cliente.ToUpper().Contains(txtNombreBuscar.Text.ToUpper()) && p.ProyectoId == idProyecto
                                          select p).ToList();
                if (proyectosFiltrados.Count > 0)
                {
                    await CargarTablaAsync(proyectosFiltrados);
                }
                else
                {
                    MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!string.IsNullOrEmpty(txtNombreBuscar.Text))
            {
                var proyectosFiltrados = (from p in proyectos
                                          where p.Cliente.ToUpper().Contains(txtNombreBuscar.Text.ToUpper())
                                          select p).ToList();
                if (proyectosFiltrados.Count > 0)
                {
                    CargarTablaAsync(proyectosFiltrados);
                }
                else
                {
                    MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!string.IsNullOrEmpty(txtNumeroProyectoBuscar.Text))
            {
                int.TryParse(txtNumeroProyectoBuscar.Text, out int idProyecto);
                var proyectosFiltrados = (from p in proyectos
                                          where p.ProyectoId == idProyecto
                                          select p).ToList();
                if (proyectosFiltrados.Count > 0)
                {
                    CargarTablaAsync(proyectosFiltrados);
                }
                else
                {
                    MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtNombreBuscar.Text = string.Empty;
            txtNumeroProyectoBuscar.Text = string.Empty;
            await CargarTablaAsync();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {

        }

        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCotizaciones listaCotizaciones = new();
            listaCotizaciones.Show();
        }

        private void listaDeInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaInforme listaInforme = new ListaInforme();
            listaInforme.Show();
        }

        private void informesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformesPendientes informesPendientes = new();
            informesPendientes.Show();
        }

        private void crearInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearInforme crearInforme = new();
            crearInforme.ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new();
            configuracion.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuario n = new();
            n.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario s = new AgregarUsuario();
            s.ShowDialog();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resumen resumen = new Resumen();
            resumen.Show();
        }

        private void checkBoxPublico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
