using Modelos;
using Negocios;

namespace Interfaz
{
    public partial class AgregarUsuario : Form
    {
        #region Constructor
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio tmpConexion = new();
            bool CamposValidos = ValidarCampos();
            if (CamposValidos)
            {
                bool LoginValido = tmpConexion.ComprobarLogin(txtLogin.Text);
                if (LoginValido)
                {
                    MessageBox.Show("Login ya registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtContrasena.Text.Equals(txtContrasenaConfirmacion.Text))
                    {
                        UsuarioNegocio tmp = new();
                        // Ingresa el usuario
                        Usuario UsuarioTemporal = new Usuario()
                        {
                            Activo = true,
                            Nombre = txtNombre.Text,
                            Login = txtLogin.Text,
                            HashContraseña = txtContrasena.Text
                        };
                        bool Resultado = tmp.CrearUsuario(UsuarioTemporal, out int idUsuario);
                        if (Resultado)
                        {
                            MessageBox.Show($"Usuario Registrado.\nId: {idUsuario}\nLogin: {UsuarioTemporal.Login}\nNombre: {UsuarioTemporal.Nombre}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UsuarioTemporal.UsuarioId = idUsuario;
                            AsignarRol(UsuarioTemporal);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void AsignarRol(Usuario usuario)
        {
            try
            {
                RolUsuarioNegocio rolUsuario = new();
                RolUsuario rolUsuario1Temporal = new();
                var resultado = MessageBox.Show("¿El rol por defecto es Vendedor, deseas cambiarlo a administrador?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resultado)
                {
                    // asigna administrador como rol
                    rolUsuario1Temporal.RolId = 1;
                    rolUsuario1Temporal.UsuarioId = usuario.UsuarioId;
                }
                else
                {
                    // asigna vendedor como rol
                    rolUsuario1Temporal.RolId = 2;
                    rolUsuario1Temporal.UsuarioId = usuario.UsuarioId;
                }
                var resultadoRol = rolUsuario.AgregarRolUsuario(rolUsuario1Temporal);
                if (resultadoRol)
                {
                    MessageBox.Show("Rol Agregado al usuario", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error interno", $"Error {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion
      
        #region Validations
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("El Login se encuentra vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    MessageBox.Show("Ingrese su contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtContrasenaConfirmacion.Text))
                    {
                        MessageBox.Show("Confirme su contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        #endregion
    }
}
