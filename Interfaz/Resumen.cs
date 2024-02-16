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
                            (i.Facturado) ?"Facturado":"No Facturado"
                            );;
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

        }

        private void btnSinFacturar_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturados_Click(object sender, EventArgs e)
        {

        }



        private void Exportado(List<Proyecto> _proyectos)
        {

        }


    }

}
