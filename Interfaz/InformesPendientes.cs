using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class InformesPendientes : Form
    {
        public InformesPendientes()
        {
            InitializeComponent();
            Creacion();
        }

        private void Creacion()
        {
            var Informes = InformeNegocio.ListUnfinished();

            if (Informes != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add(" Entrega Maxima");
                dt.Columns.Add("Cliente");
                dt.Columns.Add("Tipo Trabajo");
                dt.Columns.Add("Técnico");
                dt.Columns.Add("Encargado");
                foreach (var item in Informes)
                {
                    dt.Rows.Add(
                        item.InformeId,
                        item.FechaMaxima.ToString(),
                        item.Proyecto.Cliente,
                        item.Proyecto.Tipo,
                        (string.IsNullOrEmpty(item.Tecnico)) ? "Sin Dato" : item.Tecnico,
                        (item.Usuario != null) ? item.Usuario.Nombre : "Sin Asignar"
                        );
                }
                dataGridViewPendientes.DataSource = dt;
                DataGridViewButtonColumn botonVer = new();
                botonVer.HeaderText = "Seleccionar";
                botonVer.Text = "Seleccionar";
                botonVer.Name = "btnVerInforme";
                dataGridViewPendientes.Columns.Add(botonVer);
                
            }
        }
    }
}
