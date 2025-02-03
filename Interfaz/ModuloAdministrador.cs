﻿using Modelos;
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
            await cargarOfertas();
            dgvProyectos.CellEndEdit += DgvProyectos_CellEndEdit;
            dgvProyectos.CellBeginEdit += dgvProyectos_CellBeginEdit;

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
        /// Carga las ofertas en el combobox
        /// </summary>
        /// <returns></returns>
        private async Task cargarOfertas()
        {
            try
            {
                OfertaNegocio ofertaNegocio = new();
                Ofertas = await ofertaNegocio.DiccionarioOfertasAsync();
                if (Ofertas != null)
                {
                    cbOfertas.Items.Clear();
                    cbOfertas.Items.Add($"1-No Asignado / No Disponible");
                    foreach (var item in Ofertas)
                    {
                        cbOfertas.Items.Add($"{item.Key}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private async Task CargarTablaAsync(List<Proyecto> proyectosFiltrados = null)
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
                dgvProyectos.Columns.Clear();
                DataTable _tabla = new();
                _tabla.Columns.Add("Id Interno");
                _tabla.Columns.Add("Vendedor");
                _tabla.Columns.Add("Cliente");
                _tabla.Columns.Add("Fecha OC");
                _tabla.Columns.Add("Factura Anticipo");
                _tabla.Columns.Add("Factura Final");
                _tabla.Columns.Add("Tipo");
                _tabla.Columns.Add("Tarea");
                _tabla.Columns.Add("Oferta");
                _tabla.Columns.Add("Monto");
                _tabla.Columns.Add("Estado");

                foreach (Proyecto i in proyectos)
                {
                    _tabla.Rows.Add(
                        i.ProyectoId,
                        i.Vendedor.Nombre,
                        i.Cliente,
                        i.FechaOC.ToString("dd MMM yy"),
                        i.FacturaAnticipoId.ToString(),
                        i.FacturaFinalId.ToString(),
                        i.Notas,
                        i.TareaId,
                        i.OfertaId,
                        i.Monto.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")),
                        i.Estado
                    );
                }

                // Botón Ver
                DataGridViewButtonColumn botonVer = new();
                botonVer.HeaderText = "Ver";
                botonVer.Text = "Ver";
                botonVer.Name = "btnVerProyecto";
                botonVer.UseColumnTextForButtonValue = true;
                dgvProyectos.Columns.Add(botonVer);

                // Botón Editar
                DataGridViewButtonColumn botonEditar = new();
                botonEditar.HeaderText = "Editar";
                botonEditar.Text = "Editar";
                botonEditar.Name = "btnEditarProyecto";
                botonEditar.UseColumnTextForButtonValue = true;
                dgvProyectos.Columns.Add(botonEditar);

                dgvProyectos.DataSource = _tabla;

                dgvProyectos.ReadOnly = false;


            }
        }
        private void dgvProyectos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvProyectos.Columns[e.ColumnIndex].Name == "Factura Anticipo" || dgvProyectos.Columns[e.ColumnIndex].Name == "Factura Final")
            {
                e.Cancel = false; // Esto asegura que la edición se permita
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show($"Solo se pueden editar las facturas");

            }
        }
        private async void DgvProyectos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar lo que sucede cuando se termina de editar una celda
            if (e.RowIndex >= 0 && e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {

                var project = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
                var p = proyectos.FirstOrDefault(e => e.ProyectoId == project);

                // Por ejemplo, puedes validar que el valor editado sea correcto
                var valorEditado = dgvProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                switch (e.ColumnIndex)
                {
                    case 6:
                        p.FacturaAnticipoId = valorEditado.ToString();
             
                        break;
                    case 7:
                       
                        p.FacturaFinalId = valorEditado.ToString();
                        break;
                    default:
                        break;
                }
                var proyectosNegocio = new ProyectoNegocios();
                proyectosNegocio.ActualizarProyecto(p);
            }
            else
            {
                MessageBox.Show($"Solo se pueden editar las facturas");

            }
        }
        /// <summary>
        /// Opciones de seleccion de botones en grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    CargarTablaAsync();
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
            await cargarOfertas();
        }

        private async void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new();
            agregarOferta.ShowDialog();
            await cargarOfertas();
        }

        /// <summary>
        /// Exporta a Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
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

                    // Título
                    worksheet.Cells[1, 1] = "Datos de exportación";
                    worksheet.get_Range("A1", "M1").Merge();
                    worksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    worksheet.Cells[1, 1].Font.Size = 14;
                    worksheet.Cells[1, 1].Font.Bold = true;

                    // Encabezados de la tabla
                    worksheet.Cells[2, "A"] = "Numero Proyecto";
                    worksheet.Cells[2, "B"] = "Vendedor";
                    worksheet.Cells[2, "C"] = "Cliente";
                    worksheet.Cells[2, "D"] = "Factura Anticipo";
                    worksheet.Cells[2, "E"] = "Factura Final";
                    worksheet.Cells[2, "F"] = "Porcentaje Anticipo";
                    worksheet.Cells[2, "G"] = "Tarea Bitrix";
                    worksheet.Cells[2, "H"] = "Fecha OC";
                    worksheet.Cells[2, "I"] = "Oferta";
                    worksheet.Cells[2, "J"] = "Fecha Inicio";
                    worksheet.Cells[2, "K"] = "Fecha Final";
                    worksheet.Cells[2, "L"] = "Monto";
                    worksheet.Cells[2, "M"] = "Tipo";

                    int contador = 3;  // Comenzamos desde la fila 3 porque las dos primeras están reservadas para el título y los encabezados
                    foreach (Proyecto item in proyectos)
                    {
                        worksheet.Cells[contador, 1] = item.ProyectoId.ToString();
                        worksheet.Cells[contador, 2] = item.Vendedor.Nombre;
                        worksheet.Cells[contador, 3] = item.Cliente;
                        worksheet.Cells[contador, 4] = item.FacturaAnticipoId;
                        worksheet.Cells[contador, 5] = item.FacturaFinalId;
                        worksheet.Cells[contador, 6] = item.PorcentajeAnticipo;
                        worksheet.Cells[contador, 7] = item.TareaId;
                        worksheet.Cells[contador, 8] = item.FechaOC.ToString("dd/MM/yy");
                        worksheet.Cells[contador, 9] = item.OfertaId.ToString();
                        worksheet.Cells[contador, 10] = item.FechaInicio.ToString("dd/MM/yy");
                        worksheet.Cells[contador, 11] = item.FechaFinal.ToString("dd/MM/yy");
                        worksheet.Cells[contador, 12] = item.Monto.ToString();
                        worksheet.Cells[contador, 13] = item.Notas;
                        contador++;
                    }

                    // Definir el rango de datos de la tabla (de A2 a M<contador-1>)
                    Excel.Range range = worksheet.get_Range("A2", "M" + (contador - 1).ToString());

                    // Crear la tabla en ese rango
                    Excel.ListObject table = worksheet.ListObjects.Add(
                        Excel.XlListObjectSourceType.xlSrcRange, // Tipo de origen de datos
                        range, // Rango que se convertirá en tabla
                        0, // Usar encabezados
                        Excel.XlYesNoGuess.xlYes, // Los encabezados están presentes
                        null); // Sin opciones adicionales

                    // Aplicar estilo de tabla (puedes elegir otro estilo según tus necesidades)
                    table.TableStyle = "TableStyleMedium9"; // Puedes cambiar el nombre del estilo si lo prefieres

                    // Ajustar el tamaño de las columnas automáticamente
                    worksheet.Columns.AutoFit();

                    // Guardar el archivo
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
                    proyectoTemporal.Contacto = txtContacto.Text;
                    proyectoTemporal.FechaOC = dtpOrdenCompra.Value;
                    proyectoTemporal.FechaInicio = dtpFechaInicio.Value;
                    proyectoTemporal.FechaFinal = dtpFechaFinal.Value;
                    proyectoTemporal.Monto = int.Parse(txtMonto.Text);
                    proyectoTemporal.Ubicacion = txtUbicacion.Text;
                    proyectoTemporal.TareaId = int.Parse(txtNumeroTarea.Text);
                    proyectoTemporal.Estado = cbEstado.Text;
                    proyectoTemporal.Notas = txtTipoTrabajo.Text;
                    proyectoTemporal.FacturaAnticipoId = txtNumeroFactura.Text;
                    proyectoTemporal.UsuarioId = (from i in Vendedores
                                                  where i.Nombre == cbVendedores.Text
                                                  select i.UsuarioId).FirstOrDefault();
                    var ofertatmp = cbOfertas.Text.Split('-');
                    proyectoTemporal.OfertaId = ofertatmp[0];
                    proyectoTemporal.Notas = "Sin notas";
                    proyectoTemporal.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                    proyectoTemporal.Autor = Temporal.UsuarioActivo.Nombre;
                    proyectoTemporal.FacturaFinalId = string.Empty;
                    proyectoTemporal.UltimaEdicion = DateTime.Today;
                    proyectoTemporal.Cliente = txtNombreCliente.Text;
                    proyectoTemporal.Enable = true;
                    var resultado = proyectoNegocios.CrearProyecto(proyectoTemporal, out int idProyecto);
                    if (resultado)
                    {
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
                bool OfertaIDValido = int.TryParse(cbOfertas.Text.Split('-').FirstOrDefault(), out int IDValido);
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
                /// Contacto
                if (string.IsNullOrEmpty(txtContacto.Text))
                {
                    lblContacto.ForeColor = Color.Red;
                    MessageBox.Show("No indicó un contacto \nSi no posee, indicar: \"No aplica\"", "Advertencia: Validación de Contacto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                /// Oferta
                if (string.IsNullOrEmpty(cbOfertas.Text))
                {
                    lblOferta.ForeColor = Color.Red;
                    MessageBox.Show("No indicó una oferta", "Advertencia: Validación Oferta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                //  Monto
                bool value = float.TryParse(txtMonto.Text, out float resultado);
                if (!value)
                {
                    lblMonto.ForeColor = Color.Red;
                    MessageBox.Show("No indicó un monto", "Advertencia: Validación Monto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    else
                    {
                        txtNumeroFactura.Text = "No hay anticipo";
                    }
                }
                // Numero Factura de anticipo
                if (string.IsNullOrEmpty(txtNumeroFactura.Text))
                {
                    lblFacturaAnticipo.ForeColor = Color.Red;
                    var response = MessageBox.Show("No indico una factura de anticipo \n¿Desea continuar?", "Advertencia: Validación Número Factura Anticipo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (response == DialogResult.No)
                    {
                        return false;
                    }
                    else
                    {
                        txtNumeroFactura.Text = "No hay factura de anticipo";
                    }
                }
                // Validación de Tarea 
                var taskNumber = int.TryParse(txtNumeroTarea.Text, out int numberTask);
                if (!taskNumber)
                {
                    lblTarea.ForeColor = Color.Red;
                    MessageBox.Show("No puede dejar el número de tarea en blanco.\nSi no posee, indique: 1", "Advertencia: Validación de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                Console.WriteLine(f.Message);
                return false;
            }
        }

        private void SetBackLabels()
        {
            lblVendedor.ForeColor = Color.Black;
            lblRazon.ForeColor = Color.Black;
            lblContacto.ForeColor = Color.Black;
            lblOferta.ForeColor = Color.Black;
            lblMonto.ForeColor = Color.Black;
            lblPorcentaje.ForeColor = Color.Black;
            lblFacturaAnticipo.ForeColor = Color.Black;
            lblTarea.ForeColor = Color.Black;

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
            cbVendedores.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            dtpOrdenCompra.Value = DateTime.Now;
            txtContacto.Text = string.Empty;
            cbOfertas.Text = string.Empty;
            txtMonto.Text = string.Empty;
            numericUpDownPorcentaje.Value = 0;
            txtNumeroFactura.Text = string.Empty;
            txtNumeroTarea.Text = string.Empty;
            txtUbicacion.Text = string.Empty;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            cbEstado.Text = string.Empty;
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtNombreBuscar.Text = string.Empty;
            txtNumeroProyectoBuscar.Text = string.Empty;
            CargarTablaAsync();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            bool parseable = float.TryParse(txtMonto.Text, out float resultado);
            if (!parseable)
            {
                MessageBox.Show($"El valor '{txtMonto.Text}' no es válido, Reviselo e intente de nuevo\nEjemplo de valor aceptable: 1520,25", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #endregion
    }
}
