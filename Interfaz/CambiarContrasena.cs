﻿using Negocios;

namespace Interfaz
{
    public partial class CambiarContrasena : Form
    {
        #region Properties
        public int idUsuario { get; set; }
        #endregion

        #region Constructor
        public CambiarContrasena()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            bool validacion = ValidarCampos();
            if (validacion)
            {
                if (txtContrasena.Text.Equals(txtVerificarContrasena.Text))
                {
                    UsuarioNegocio usuarioNegocio = new();
                    bool resultado = usuarioNegocio.CambiarContraseña(idUsuario, txtContrasena.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Contraseña modificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
      
        #region Validations
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("El campo contrasena no puede estar vacio", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtVerificarContrasena.Text))
                {
                    MessageBox.Show("El campo confirmar contrasena no puede estar vacio", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        #endregion
    }
}
