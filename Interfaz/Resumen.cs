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
        private Thread Finalizados = null;
        private Thread Pendientes = null;

        public Resumen()
        {
            InitializeComponent();

        }

        void loadPendientes()
        {
            Pendientes = new(new ThreadStart(() =>
            {
                dataGridViewPendientes.Invoke(async () =>
                {
                    ProyectoNegocios pN = new();
                    var _Proyectos = await pN.ListaPendientes();


                    DataTable _tabla = new();
                    _tabla.Columns.Add("Id Interno");
                    _tabla.Columns.Add("Vendedor");
                    _tabla.Columns.Add("Cliente");
                    _tabla.Columns.Add("Provincia");
                    _tabla.Columns.Add("Tipo Trabajo");
                    _tabla.Columns.Add("Fecha OC");
                    _tabla.Columns.Add("Factura Anticipo");
                    _tabla.Columns.Add("Porcentaje de Anticipo");
                    _tabla.Columns.Add("Tarea");
                    _tabla.Columns.Add("Oferta");
                    _tabla.Columns.Add("Fecha Inicio");
                    _tabla.Columns.Add("Fecha Final");
                    _tabla.Columns.Add("Monto");
                    _tabla.Columns.Add("Estado");
                    foreach (Proyecto i in _Proyectos)
                    {
                        _tabla.Rows.Add(
                            i.ProyectoId,
                            i.Vendedor.Nombre,
                            i.Cliente,
                            i.Provincia,
                            i.Tipo,
                            i.FechaOC.ToString("dd MMM yy"),
                            i.FacturaAnticipoId.ToString(),
                            $"{i.PorcentajeAnticipo}%",
                            i.TareaId,
                            i.OfertaId,
                            i.FechaInicio.ToString("dd MMM yy"),
                            i.FechaFinal.ToString("dd MMM yy"),
                            i.Monto.ToString("C", CultureInfo.CurrentCulture),
                            i.Estado
                            );
                    }
                    dataGridViewPendientes.DataSource = _tabla;
                });

            }));

            Pendientes.Start();
        }

        void loadFinalizados()
        {
            Pendientes = new(new ThreadStart(() =>
            {
                dataGridViewFinalizados.Invoke(async () =>
                {
                    ProyectoNegocios pN = new();
                    var _Proyectos = await pN.ListaFinalizados();


                    DataTable _tabla = new();
                    _tabla.Columns.Add("Id Interno");
                    _tabla.Columns.Add("Vendedor");
                    _tabla.Columns.Add("Cliente");
                    _tabla.Columns.Add("Tipo Trabajo");
                    _tabla.Columns.Add("Fecha OC");
                    _tabla.Columns.Add("Factura Anticipo");
                    _tabla.Columns.Add("Porcentaje Anticipo");
                    _tabla.Columns.Add("Tarea");
                    _tabla.Columns.Add("Oferta");
                    _tabla.Columns.Add("Fecha Inicio");
                    _tabla.Columns.Add("Fecha Final");
                    _tabla.Columns.Add("Monto");
                    _tabla.Columns.Add("Estado");
                    foreach (Proyecto i in _Proyectos)
                    {
                        _tabla.Rows.Add(
                            i.ProyectoId,
                            i.Vendedor.Nombre,
                            i.Cliente,
                            i.Tipo,
                            i.FechaOC.ToString("dd MMM yy"),
                            i.FacturaAnticipoId.ToString(),
                            $"{i.PorcentajeAnticipo}%",
                            i.TareaId,
                            i.OfertaId,
                            i.FechaInicio.ToString("dd MMM yy"),
                            i.FechaFinal.ToString("dd MMM yy"),
                            i.Monto.ToString("C", CultureInfo.CurrentCulture),
                            i.Estado
                            );
                    }
                    dataGridViewFinalizados.DataSource = _tabla;
                });

            }));

            Pendientes.Start();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            loadPendientes();
            loadFinalizados();
        }
    }
}
