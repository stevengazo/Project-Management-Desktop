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
using Modelos;
using Negocios;

namespace Interfaz
{
    public partial class Resumen : Form
    {
        private Thread HFinalizados = null;
        private Thread HPendientes = null;
        private Thread HSinFactura = null;
        private Thread HFacturados = null;
        private Thread Exportado = null;
        private List<Proyecto> _Proyectos = new();

        public Resumen()
        {
            InitializeComponent();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            CargaDatos();
            Finalizados();
        }

        private void Finalizados()
        {
            HFinalizados = new Thread(new ParameterizedThreadStart(Cargar));
            var prFinalizados = (from i in _Proyectos where i.Finalizado == true select i).ToList();

            HPendientes = new Thread(new ParameterizedThreadStart(Cargar));
            var prPendientes = (from i in _Proyectos where i.Finalizado != true select i).ToList();

            HSinFactura = new Thread(new ParameterizedThreadStart(Cargar));
            var prSinFactura = (from i in _Proyectos where i.Facturado == false select i).ToList();

            HFacturados = new Thread(new ParameterizedThreadStart(Cargar));
            var prFacturado = (from i in _Proyectos where i.Facturado == true select i).ToList();

            HFinalizados.Start(new object[] { prFinalizados, dataGridViewFinalizados });
            HPendientes.Start(new object[] { prPendientes, dataGridViewPendientes });
            HSinFactura.Start(new object[] { prSinFactura, dataGridViewSinFacturar });
            HFacturados.Start(new object[] { prFacturado, dataGridViewFacturados });

        }

        private void Cargar(object parametros)
        {
            // Convertimos los parámetros en un array de objetos
            object[] args = (object[])parametros;

            // Obtenemos los parámetros individuales
            List<Proyecto> listaProyectos = (List<Proyecto>)args[0];
            DataGridView dataGridViewD = (DataGridView)args[1];

            if (listaProyectos.Count > 0)
            {
                dataGridViewD.Invoke(new Action(() =>
                {
                    dataGridViewD.Columns.Clear();
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
                    _tabla.Columns.Add("Finalizado");
                    _tabla.Columns.Add("Facturado");
                    _tabla.Columns.Add("Factura");

                    foreach (Proyecto i in listaProyectos)
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
                            i.Estado,
                            (i.Finalizado) ? "Finalizado" : "No finalizado",
                            (i.Facturado) ? "Facturado" : "No Facturado",
                            i.Factura
                            ); ;
                    }
                    dataGridViewD.DataSource = _tabla;
                }));
            }

        }

        private void CargaDatos()
        {
            ProyectoNegocios pN = new ProyectoNegocios();
            _Proyectos = pN.ListaProyectosAno();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnPendientes_Click(object sender, EventArgs e)
        {
            var prPendientes = (from i in _Proyectos where i.Finalizado == true select i).ToList();

            if (Exportado == null)
            {
                Exportado = new Thread(
                    new ThreadStart(() =>
                    {
                        ExportadoExcel(prPendientes);
                    })
                    );
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
                    Exportado = new Thread(
                        new ThreadStart(() =>
                        {
                            ExportadoExcel(prPendientes);
                        })
                        );
                    Exportado.SetApartmentState(ApartmentState.STA);
                    Exportado.Start();
                }
            }

        }
        private void btnSinFacturar_Click(object sender, EventArgs e)
        {
            var prSinFactura = (from i in _Proyectos where i.Facturado == false select i).ToList();

            if (Exportado == null)
            {
                Exportado = new Thread(
                    new ThreadStart(() =>
                    {
                        ExportadoExcel(prSinFactura);
                    })
                    );
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
                    Exportado = new Thread(
                        new ThreadStart(() =>
                        {
                            ExportadoExcel(prSinFactura);
                        })
                        );
                    Exportado.SetApartmentState(ApartmentState.STA);
                    Exportado.Start();
                }
            }

        }
        private void btnFacturados_Click(object sender, EventArgs e)
        {
            var prFacturado = (from i in _Proyectos where i.Facturado == true select i).ToList();

            if (Exportado == null)
            {
                Exportado = new Thread(
                    new ThreadStart(() =>
                    {
                        ExportadoExcel(prFacturado);
                    })
                    );
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
                    Exportado = new Thread(
                        new ThreadStart(() =>
                        {
                            ExportadoExcel(prFacturado);
                        })
                        ) ;
                    Exportado.SetApartmentState(ApartmentState.STA);
                    Exportado.Start();
                }
            }

        }
        private void btnFinalizados_Click(object sender, EventArgs e)
        {
            var prFinalizados = (from i in _Proyectos where i.Finalizado == true select i).ToList();

            if (Exportado == null)
            {
                Exportado = new Thread(
                    new ThreadStart(() =>
                    {
                        ExportadoExcel(prFinalizados);
                    })
                    );
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
                    Exportado = new Thread(
                        new ThreadStart(() =>
                        {
                            ExportadoExcel(prFinalizados);
                        })
                        );
                    Exportado.SetApartmentState(ApartmentState.STA);
                    Exportado.Start();
                }
            }

        }
        private void ExportadoExcel(object proyectos)
        {
            var _proyectos = (List<Proyecto>) proyectos;
            try
            {
                saveFileDialog.Title = "Exportar a Excel";
                saveFileDialog.Filter = "Excel|*.xlsx";
                saveFileDialog.FileName = $"Proyectos- TIPO - {DateTime.Now.ToString("yy-MM-dd hh-mm-ss")}";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string URLArchivo = saveFileDialog.FileName;
                    var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveSheet;
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
                    worksheet.Cells[1, "L"] = "Factura";
                    worksheet.Cells[1, "M"] = "Tarea";
                    worksheet.Cells[1, "N"] = "Descripciones";
                    worksheet.Cells[1, "O"] = "Provincia";
                    worksheet.Cells[1, "P"] = "Ubicación";
                    worksheet.Cells[1, "Q"] = "Tarea";
                    worksheet.Cells[1, "R"] = "Vendedor";
                    worksheet.Cells[1, "S"] = "Estado";
                    worksheet.Cells[1, "T"] = "Fecha Ingreso";
                    worksheet.Cells[1, "U"] = "Creado Por";
                    worksheet.Cells[1, "V"] = "Ultima Edición";
                    worksheet.Cells[1, "W"] = "Ultimo Editor";

                    int contador = 2;
                    foreach (Proyecto item in _proyectos)
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
                        worksheet.Cells[contador, 12] = item.Factura; // Factura
                        worksheet.Cells[contador, 13] = item.TareaId.ToString(); // TAREA                        
                        worksheet.Cells[contador, 14] = item.Descripcion.ToLower(); // DESCRIPCIONES
                        worksheet.Cells[contador, 15] = item.Provincia; // PROVINCIA
                        worksheet.Cells[contador, 16] = item.Ubicacion.ToLower(); // Ubicación
                        worksheet.Cells[contador, 17] = item.TareaId.ToString(); // Tarea
                        worksheet.Cells[contador, 18] = item.Vendedor.Nombre; // Vendedor
                        worksheet.Cells[contador, 19] = item.Estado; // Estado
                        worksheet.Cells[contador, 20] = item.FechaIngreso.ToShortDateString(); // Fecha Ingreso
                        worksheet.Cells[contador, 21] = item.Autor; // Creado Por
                        worksheet.Cells[contador, 22] = item.UltimaEdicion.ToShortDateString(); // Ultima Edicion
                        worksheet.Cells[contador, 23] = item.UltimoEditor; // Ultimo Editor
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




    }

}
