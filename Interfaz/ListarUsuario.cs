using Modelos;
using Negocios;
using System.Data;

namespace Interfaz
{
	public partial class ListarUsuario : Form
	{
		private List<Usuario> usuarios;
		private RolUsuarioNegocio RolUsuario = new RolUsuarioNegocio();
		public ListarUsuario()
		{
			InitializeComponent();
		}
		public async Task CargarUsuarios()
		{
			try
			{
				UsuarioNegocio tmp = new();
				usuarios = await tmp.ListarUsuariosAsync();
				if (usuarios.Count > 0)
				{
					dgvUsuarios.Columns.Clear();
					DataTable data = new();
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


					DataGridViewButtonColumn botonRolVentas = new();
					botonRolVentas.HeaderText = "Rol Ventas";
					botonRolVentas.Text = "Rol Ventas";
					botonRolVentas.Name = "btnRolVentas";
					botonRolVentas.UseColumnTextForButtonValue = true;
					dgvUsuarios.Columns.Add(botonRolVentas);

					DataGridViewButtonColumn botonRolAdmin = new();
					botonRolAdmin.HeaderText = "Rol Admin";
					botonRolAdmin.Text = "Rol Admin";
					botonRolAdmin.Name = "btnRolAdmin";
					botonRolAdmin.UseColumnTextForButtonValue = true;
					dgvUsuarios.Columns.Add(botonRolAdmin);
				}
				else
				{
					MessageBox.Show("No se lograron obtener datos", "Informaci");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
		private async void ListarUsuario_Load(object sender, EventArgs e)
		{
			await CargarUsuarios();
		}

		private async void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// CAMBIAR CONTRASENA
				if (e.ColumnIndex == 4)
				{
					// Obtener el id
					CambiarContrasena cambiarContrasena = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					cambiarContrasena.idUsuario = id;
					cambiarContrasena.ShowDialog();
				}
				/// ESTADO DEL USUARIO 
				else if (e.ColumnIndex == 3)
				{
					
					UsuarioNegocio usuarioNegocio = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					var usuario = usuarioNegocio.ObtenerUsuario(id);
					if (usuario != null)
					{
						var estado = (usuario.Activo) ? "Activo" : "Inactivo";
						var resultado = MessageBox.Show($"El usuario {usuario.Nombre} se encuentra {estado}\n¿Deseas cambiar su estado? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (resultado == DialogResult.Yes)
						{
							usuario.Activo = !usuario.Activo;
							var resultado1 = usuarioNegocio.ActualizarUsuario(usuario);
							if (resultado1)
							{
								MessageBox.Show("Usuario actualizado", "Informaicon", MessageBoxButtons.OK);
							}
						}
					}
					await CargarUsuarios();
				}
				/// ROL DE VENDEDOR
				else if (e.ColumnIndex == 5)
				{
					UsuarioNegocio usuarioNegocio = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					var usuario = usuarioNegocio.ObtenerUsuario(id);

					bool PoseeRol = RolUsuario.VerificarRol(usuario.UsuarioId, 2);
					if (PoseeRol)
					{
						// BORRADO DEL ROL
						var respuesta = MessageBox.Show("El usuario posee el rol de vendedor, deseas quitarlo?", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (respuesta == DialogResult.Yes)
						{
							var rol = RolUsuario.ObtenerRolUsuario(usuario.UsuarioId, 2);
							if (rol != null)
							{
								var resultado = RolUsuario.BorrarRolUsuario(rol);
								if (resultado)
								{
									MessageBox.Show("Rol Borrado", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
									CargarUsuarios();
								}
							}
						}
					}
					else
					{
						// CONSULTAR SI AÑADIR ROL
						var respuesta = MessageBox.Show("El usuario no posee el rol de vendedor, deseas añadirlo?", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (respuesta == DialogResult.Yes)
						{
							RolUsuario rol = new RolUsuario()
							{
								RolId = 2,
								UsuarioId = usuario.UsuarioId
							};
							var d = RolUsuario.AgregarRolUsuario(rol);
							if (d)
							{
								MessageBox.Show("Rol Añadido al usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
								CargarUsuarios();
							}
						}
					}

				}
				/// ROL DE ADMINISTRADOR
				else if (e.ColumnIndex == 6)
				{
					UsuarioNegocio usuarioNegocio = new();
					var id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
					var usuario = usuarioNegocio.ObtenerUsuario(id);

					bool PoseeRol = RolUsuario.VerificarRol(usuario.UsuarioId, 1);
					if (PoseeRol)
					{
						var respuesta = MessageBox.Show("El usuario posee el rol de administrador, deseas quitarlo?", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (respuesta == DialogResult.Yes)
						{
							var rol = RolUsuario.ObtenerRolUsuario(usuario.UsuarioId, 1);
							if (rol != null)
							{
								var resultado = RolUsuario.BorrarRolUsuario(rol);
								if (resultado)
								{
									MessageBox.Show("Rol Borrado", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
									CargarUsuarios();
								}
							}
						}
					}
					else
					{
						// CONSULTAR SI AÑADIR ROL
						var respuesta = MessageBox.Show("El usuario no posee el rol de administrador, deseas añadirlo?", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (respuesta == DialogResult.Yes)
						{
							RolUsuario rol = new RolUsuario()
							{
								RolId = 2,
								UsuarioId = usuario.UsuarioId
							};
							var d = RolUsuario.AgregarRolUsuario(rol);
							if (d)
							{
								MessageBox.Show("Rol Añadido al usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
								CargarUsuarios();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
