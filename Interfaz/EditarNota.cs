using Modelos;
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
    public partial class EditarNota : Form
    {

        internal Nota Nota { get; set; } = new Nota();
        public EditarNota()
        {
            InitializeComponent();

            Nota = NotaNegocio.GetNotaById(Temporal.NotaId);
            if (Nota != null)
            {
                txtTitulo.Text = Nota.Titulo.ToString();
                txtDescripcion.Text = Nota.Descripcion.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nota.Titulo = txtTitulo.Text;
                Nota.Descripcion = txtDescripcion.Text;
                Nota.UltimaModificacion = DateTime.Now;
                Nota.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                NotaNegocio.Edit(Nota);
                MessageBox.Show("Nota Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
