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
					dgvUsuarios.Columns.Clear();
					DataTable data = new DataTable();
					data.Columns.Add("Id");
					data.Columns.Add("Nombre");
					data.Columns.Add("Estado");


					foreach (Usuario item in usuarios)
					{
						string estado = "";
						if (item.Activo)
						{
							estado = "Usuario Activo";
						}
						else
						{
							estado = "Usuario inactivo";
						}

						data.Rows.Add(
							item.UsuarioId,
							item.Nombre,
							estado
							);
					}
					dgvUsuarios.DataSource = data;
					DataGridViewButtonColumn botonEditar = new();
					botonEditar.HeaderText = "Cambiar Estado";
					botonEditar.Text = "Cambiar Estado";
					botonEditar.Name = "Cambiar";
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
				if(e.ColumnIndex== 4)
				{
					// Obtener el id
					CambiarContrasena cambiarContrasena = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					cambiarContrasena.idUsuario= id;
					cambiarContrasena.ShowDialog();	
				}
				else if(e.ColumnIndex == 3)
				{
					UsuarioNegocio usuarioNegocio = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					var usuario = usuarioNegocio.ObtenerUsuario(id);
					if(usuario != null)
					{
						var estado = (usuario.Activo) ? "Activo" : "Inactivo";
						var resultado = MessageBox.Show($"El usuario {usuario.Nombre} se encuentra {estado}\n¿Deseas cambiar su estado? ","Consulta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
						if(resultado == DialogResult.Yes)
						{
							usuario.Activo = !usuario.Activo;
							var resultado1 = usuarioNegocio.ActualizarUsuario(usuario);
							if (resultado1)
							{
								MessageBox.Show("Usuario actualizado", "Informaicon", MessageBoxButtons.OK);
							}
						}
					}
					CargarUsuarios();
				}

			}catch (Exception ex) {
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}
	}
}
