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
    public partial class VerNota : Form
    {
        public VerNota()
        {
            InitializeComponent();
            var nota = NotaNegocio.GetNotaById(Temporal.NotaId);
            if (nota != null)
            {
                txtAutor.Text = nota.Autor;
                txtDescripcion.Text = nota.Descripcion;
                txtTitulo.Text = nota.Titulo;
                txtFecha.Text = nota.Creacion.ToLongDateString();
                txtUltimaEdicion.Text = nota.UltimaModificacion.ToLongDateString();
                txtUltimoEditor.Text = nota.UltimoEditor;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
