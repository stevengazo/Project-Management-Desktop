using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Modelos;

namespace Interfaz
{
	public partial class ListarCliente : Form
	{
		public ListarCliente()
		{
			InitializeComponent();
		}

		private void ListarCliente_Load(object sender, EventArgs e)
		{
			CargarClientes();
		}
		private void CargarClientes()
		{
			try
			{
				ClienteNegocio negocio = new ClienteNegocio();
				List<Cliente> clientes= new List<Cliente>();
				clientes = negocio.ListarClientes();

				if(clientes.Count > 0 )
				{
					DataTable data= new DataTable();
					data.Columns.Add("Id");
					data.Columns.Add("Razon Social");
					data.Columns.Add("Nombre Comercial");
					data.Columns.Add("Cedula");

					foreach (var item in clientes)
					{
						data.Rows.Add(
										item.ClienteId.ToString(),
										item.RazonSocial,
										item.NombreComercial,
										item.Cedula);
					}
					dgvCliente.DataSource = data;
					DataGridViewButtonColumn botonVer = new();
					botonVer.HeaderText = "Ver";
					botonVer.Text = "Ver";
					botonVer.Name = "btnVerProyecto";
					botonVer.UseColumnTextForButtonValue = true;
					dgvCliente.Columns.Add(botonVer);
				}
				else
				{
					MessageBox.Show("No se lograron obtener datos", "Informaci");
				}
				

			}catch (Exception ex) { 
				MessageBox.Show($"Erro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
