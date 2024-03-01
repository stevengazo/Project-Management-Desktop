using Modelos;
using Negocio;
using System.Data;
using System.Globalization;

namespace Interfaz
{
    public partial class ListarOferta : Form
    {

        private List<Oferta> ListaOfertas { get; set; }

        private Thread Exportado;
        private Thread HiloCargaDatos = null;

        public ListarOferta()
        {
            InitializeComponent();
        }

        private async void ListarOferta_Load(object sender, EventArgs e)
        {
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }
        }

        private async Task CargarTablaVendedores(List<Oferta> lista = null)
        {
            try
            {
                if (lista != null)
                {
                    ListaOfertas = lista;
                }
                else
                {
                    int IdUsuario = Temporal.UsuarioActivo.UsuarioId;
                    OfertaNegocio ofertaNegocio = new();
                    ListaOfertas = await ofertaNegocio.ListaOfertasPorAñoAsync(DateTime.Now.Year, IdUsuario);
                }
                if (ListaOfertas.Count > 0)
                {
                    // Add button to See
                    dgvOfertas.Columns.Clear();
                    DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
                    botonVer.HeaderText = "Ver";
                    botonVer.Text = "Ver";
                    botonVer.Name = "btnVer";
                    botonVer.UseColumnTextForButtonValue = true;
                    dgvOfertas.Columns.Add(botonVer);
                    // Add Button to Edit
                    DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn();
                    botonEditar.HeaderText = "Editar";
                    botonEditar.Text = "Editar";
                    botonEditar.Name = "btnEditar";
                    botonEditar.UseColumnTextForButtonValue = true;
                    dgvOfertas.Columns.Add(botonEditar);
                    /// Add Columns 
                    DataTable _tabla = new();
                    _tabla.Columns.Add("Oferta Id");
                    _tabla.Columns.Add("Fecha");
                    _tabla.Columns.Add("Monto");
                    _tabla.Columns.Add("Estado");
                    _tabla.Columns.Add("Cliente");
                    _tabla.Columns.Add("Categoria");
                    _tabla.Columns.Add("Cotizado Por");
                    _tabla.Columns.Add("Descripción");

                    foreach (Oferta item in ListaOfertas)
                    {
                        _tabla.Rows.Add(
                            $"CM-{item.OfertaId.ToString()}", // Oferta Id
                            item.Fecha.ToLongDateString(), // Fecha
                            item.Monto.ToString(), // Monto
                            item.Estado, // Estado
                            item.Cliente, // Cliente
                            item.Categoria, //Categoria
                            item.EncargadoCotizador, // Cotizado por
                            item.Observaciones // descripcion
                            );
                    }
                    dgvOfertas.DataSource = _tabla;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno - {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CargarTablaAdministradores(List<Oferta> lista = null)
        {
            if (lista != null)
            {
                ListaOfertas = lista;
            }
            else
            {
                OfertaNegocio ofertaNegocio = new();
                ListaOfertas = await ofertaNegocio.ListaOfertasAsync();
            }
            if (ListaOfertas.Count > 0)
            {
                dgvOfertas.Columns.Clear();
                DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
                botonVer.HeaderText = "Ver";
                botonVer.Text = "Ver";
                botonVer.Name = "btnVer";
                botonVer.UseColumnTextForButtonValue = true;
                dgvOfertas.Columns.Add(botonVer);


                DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn();
                botonEditar.HeaderText = "Editar";
                botonEditar.Text = "Editar";
                botonEditar.Name = "btnEditar";
                botonEditar.UseColumnTextForButtonValue = true;
                dgvOfertas.Columns.Add(botonEditar);

                DataTable _tabla = new();
                _tabla.Columns.Add("Oferta Id");
                _tabla.Columns.Add("Cliente");
                _tabla.Columns.Add("Categoria");
                _tabla.Columns.Add("Fecha");
                _tabla.Columns.Add("Monto");
                _tabla.Columns.Add("Estado");
                _tabla.Columns.Add("Vendedor");
                _tabla.Columns.Add("Creado por");
                _tabla.Columns.Add("Cotizado Por");
                _tabla.Columns.Add("Descripcion");

                foreach (Oferta item in ListaOfertas)
                {
                    _tabla.Rows.Add(
                        $"CM-{item.OfertaId.ToString()}",
                        item.Cliente,
                        item.Categoria,
                        item.Fecha.ToLongDateString(),
                        item.Monto.ToString(),
                        item.Estado,
                        item.Encargado.Nombre,
                        item.AutorPrespuesto,
                        item.EncargadoCotizador,
                        item.Observaciones
                        );
                }
                dgvOfertas.DataSource = _tabla;

            }
            else
            {

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new();
            agregarOferta.ShowDialog();
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }

        }

        private async void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            txtNumeroOferta.Text = string.Empty;
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtNumeroOferta.Text, out int numeroOferta);
                var cliente = (string.IsNullOrEmpty(txtCliente.Text)) ? string.Empty : txtCliente.Text;
                List<Oferta> busqueda = new List<Oferta>();
                OfertaNegocio tmp = new OfertaNegocio();
                if (Temporal.TipoLogin.Equals("Administrador"))
                {
                    busqueda = tmp.BuscarOferta(numeroOferta: numeroOferta, Cliente: cliente);
                    CargarTablaAdministradores(busqueda);
                }
                else
                {
                    busqueda = tmp.BuscarOferta(numeroOferta: numeroOferta, Cliente: cliente, idUser: Temporal.UsuarioActivo.UsuarioId);
                    CargarTablaVendedores(busqueda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    // Obtener el id
                    var dato = (dgvOfertas.Rows[e.RowIndex].Cells[2].Value.ToString()).Split('-');
                    var id = int.Parse(dato[1]);
                    VerOferta verOferta = new VerOferta();
                    verOferta.idOferta = id;
                    verOferta.Show();
                }
                else if (e.ColumnIndex == 1)
                {
                    // Obtener el id
                    var dato = (dgvOfertas.Rows[e.RowIndex].Cells[2].Value.ToString()).Split('-');
                    var id = int.Parse(dato[1]);
                    EditarOferta editarOferta = new() { idOferta = id };
                    editarOferta.ShowDialog();
                    if (Temporal.TipoLogin.Equals("Administrador"))
                    {
                        CargarTablaAdministradores();
                    }
                    else
                    {
                        CargarTablaVendedores();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveSheet;
                    worksheet.Cells[1, "A"] = "ID";
                    worksheet.Cells[1, "B"] = "Fecha";
                    worksheet.Cells[1, "C"] = "DDCE";
                    worksheet.Cells[1, "D"] = "Ionizante";
                    worksheet.Cells[1, "E"] = "Supresor";
                    worksheet.Cells[1, "F"] = "Torre";
                    worksheet.Cells[1, "G"] = "Malla";
                    worksheet.Cells[1, "H"] = "Otros";
                    worksheet.Cells[1, "I"] = "Categoria";
                    worksheet.Cells[1, "J"] = "Tarea Id";
                    worksheet.Cells[1, "K"] = "Medio Contacto";
                    worksheet.Cells[1, "L"] = "Notas";
                    worksheet.Cells[1, "M"] = "Provincia";
                    worksheet.Cells[1, "N"] = "Observaciones";
                    worksheet.Cells[1, "O"] = "Encargado Cotizador";
                    worksheet.Cells[1, "P"] = "Autor Presupuesto";
                    worksheet.Cells[1, "Q"] = "Cliente";
                    worksheet.Cells[1, "R"] = "Estado";
                    worksheet.Cells[1, "S"] = "Vendedor";

                    int contador = 2;
                    foreach (var item in ListaOfertas)
                    {
                        worksheet.Cells[contador, 1] = item.OfertaId.ToString(); // id
                        worksheet.Cells[contador, 2] = item.Fecha.ToLongDateString(); // cLIENTE
                        worksheet.Cells[contador, 3] = (item.DDCE) ? "Requiere" : ""; // ddce
                        worksheet.Cells[contador, 4] = (item.Ionizante) ? "Requiere" : ""; // Ionizante
                        worksheet.Cells[contador, 5] = (item.Supresor) ? "Requiere" : ""; // Supresor
                        worksheet.Cells[contador, 6] = (item.Torre) ? "Requiere" : ""; // Torre
                        worksheet.Cells[contador, 7] = (item.Malla) ? "Requiere" : ""; // Malla
                        worksheet.Cells[contador, 8] = (item.Otros) ? "Requiere" : ""; // otros
                        worksheet.Cells[contador, 9] = item.Categoria; // Categoria
                        worksheet.Cells[contador, 10] = item.TareaId.ToString();
                        worksheet.Cells[contador, 11] = item.MedioContacto.ToString();// Medio Contacto
                        worksheet.Cells[contador, 12] = item.Notas.ToLower(); // Notas
                        worksheet.Cells[contador, 13] = item.Provincia.ToString(); // Provincia
                        worksheet.Cells[contador, 14] = item.Observaciones; // Observaciones
                        worksheet.Cells[contador, 15] = item.EncargadoCotizador.ToString();
                        worksheet.Cells[contador, 16] = item.AutorPrespuesto.ToString(); // Autor Presupuesto
                        worksheet.Cells[contador, 17] = item.Cliente; // Cliente
                        worksheet.Cells[contador, 18] = item.Estado;
                        worksheet.Cells[contador, 19] = item.Encargado.Nombre;
                        contador++;
                    }
                    ExcelApp.ActiveWorkbook.SaveAs(URLArchivo, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
                    ExcelApp.ActiveWorkbook.Close();
                    ExcelApp.Quit();
                    MessageBox.Show("Documento Generado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            if (Exportado == null)
            {
                Exportado = new Thread(ExportadoExcel);
                Exportado.SetApartmentState(ApartmentState.STA);
                Exportado.Start();
            }
            else
            {
                if (Exportado.ThreadState == ThreadState.Running)
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
    }
}
