using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Interfaz
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CambiarContrasena cambiarContrasena = new CambiarContrasena();
            cambiarContrasena.idUsuario = Temporal.UsuarioActivo.UsuarioId;
            cambiarContrasena.ShowDialog();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Temporal.UsuarioActivo.Nombre;
            txtUsuario.Text = Temporal.UsuarioActivo.Login;
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                Temporal.UsuarioActivo.Nombre = txtNombre.Text;
                UsuarioNegocio negocio = new UsuarioNegocio();
                negocio.ActualizarUsuario(Temporal.UsuarioActivo);
                MessageBox.Show("Usuario Actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}
