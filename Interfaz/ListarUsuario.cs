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
	public partial class ListarUsuario : Form
	{
		private List<Usuario> usuarios;
		public ListarUsuario()
		{
			InitializeComponent();
		}
		public void CargarUsuarios()
		{
			try
			{
				UsuarioNegocio tmp = new UsuarioNegocio();
				usuarios = tmp.ListarUsuarios();
				if (usuarios.Count > 0)
				{
					DataTable data = new DataTable();
					data.Columns.Add("Id");
					data.Columns.Add("Nombre");


					foreach (Usuario item in usuarios)
					{
						
						data.Rows.Add(
							item.UsuarioId,
							item.Nombre
							);
					}
					dgvUsuarios.DataSource = data;
					DataGridViewButtonColumn botonEditar = new();
					botonEditar.HeaderText = "Editar";
					botonEditar.Text = "Editar";
					botonEditar.Name = "btnEditar";
					botonEditar.UseColumnTextForButtonValue = true;
					dgvUsuarios.Columns.Add(botonEditar);
					dgvUsuarios.DataSource = data;

					DataGridViewButtonColumn botonContrasena = new();
					botonContrasena.HeaderText = "Contrasena";
					botonContrasena.Text = "Contrasena";
					botonContrasena.Name = "btnContrasena";
					botonContrasena.UseColumnTextForButtonValue = true;
					dgvUsuarios.Columns.Add(botonContrasena);
					
				}
				else
				{
					MessageBox.Show("No se lograron obtener datos", "Informaci");
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);

			}
		}
		private void ListarUsuario_Load(object sender, EventArgs e)
		{
			CargarUsuarios();
		}

		private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if(e.ColumnIndex== 3)
				{
					// Obtener el id
					CambiarContrasena cambiarContrasena = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					cambiarContrasena.idUsuario= id;
					cambiarContrasena.ShowDialog();	
				}

			}catch (Exception ex) {
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}
	}
}
