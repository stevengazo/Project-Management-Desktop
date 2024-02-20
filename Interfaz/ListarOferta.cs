using Modelos;
using Negocio;
using System.Data;
using System.Globalization;

namespace Interfaz
{
    public partial class ListarOferta : Form
    {

        private List<Oferta> ListaOfertas { get; set; }

        private Thread HiloCargaDatos = null;

        public ListarOferta()
        {
            InitializeComponent();
        }

        private async void ListarOferta_Load(object sender, EventArgs e)
        {
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }
        }

        private async Task CargarTablaVendedores(List<Oferta> lista = null)
        {
            try
            {
                if (lista != null)
                {
                    ListaOfertas = lista;
                }
                else
                {
                    int IdUsuario = Temporal.UsuarioActivo.UsuarioId;
                    OfertaNegocio ofertaNegocio = new();
                    ListaOfertas = await ofertaNegocio.ListaOfertasPorAñoAsync(DateTime.Now.Year, IdUsuario);
                }
                if (ListaOfertas.Count > 0)
                {
                    // Add button to See
                    dgvOfertas.Columns.Clear();
                    DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
                    botonVer.HeaderText = "Ver";
                    botonVer.Text = "Ver";
                    botonVer.Name = "btnVer";
                    botonVer.UseColumnTextForButtonValue = true;
                    dgvOfertas.Columns.Add(botonVer);
                    // Add Button to Edit
                    DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn();
                    botonEditar.HeaderText = "Editar";
                    botonEditar.Text = "Editar";
                    botonEditar.Name = "btnEditar";
                    botonEditar.UseColumnTextForButtonValue = true;
                    dgvOfertas.Columns.Add(botonEditar);
                    /// Add Columns 
                    DataTable _tabla = new();
                    _tabla.Columns.Add("Oferta Id");
                    _tabla.Columns.Add("Fecha");
                    _tabla.Columns.Add("Monto");
                    _tabla.Columns.Add("Estado");
                    _tabla.Columns.Add("Cliente");
                    _tabla.Columns.Add("Encargado");
                    _tabla.Columns.Add("Cotizado Por");

                    foreach (Oferta item in ListaOfertas)
                    {
                        _tabla.Rows.Add(
                            $"CM-{item.OfertaId.ToString()}",
                            item.Fecha.ToLongDateString(),
                            item.Monto.ToString(),
                            item.Estado,
                            item.Cliente,
                            item.Encargado.Nombre,
                            item.EncargadoCotizador
                            );
                    }
                    dgvOfertas.DataSource = _tabla;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno - {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CargarTablaAdministradores(List<Oferta> lista = null)
        {
            if (lista != null)
            {
                ListaOfertas = lista;
            }
            else
            {
                OfertaNegocio ofertaNegocio = new();
                ListaOfertas = await ofertaNegocio.ListaOfertasAsync();
            }
            if (ListaOfertas.Count > 0)
            {
                dgvOfertas.Columns.Clear();
                DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
                botonVer.HeaderText = "Ver";
                botonVer.Text = "Ver";
                botonVer.Name = "btnVer";
                botonVer.UseColumnTextForButtonValue = true;
                dgvOfertas.Columns.Add(botonVer);


                DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn();
                botonEditar.HeaderText = "Editar";
                botonEditar.Text = "Editar";
                botonEditar.Name = "btnEditar";
                botonEditar.UseColumnTextForButtonValue = true;
                dgvOfertas.Columns.Add(botonEditar);

                DataTable _tabla = new();
                _tabla.Columns.Add("Oferta Id");
                _tabla.Columns.Add("Cliente");
                _tabla.Columns.Add("Fecha");
                _tabla.Columns.Add("Monto");
                _tabla.Columns.Add("Estado");
                _tabla.Columns.Add("Vendedor");
                _tabla.Columns.Add("Creado por");
                _tabla.Columns.Add("Cotizado Por");

                foreach (Oferta item in ListaOfertas)
                {
                    _tabla.Rows.Add(
                        $"CM-{item.OfertaId.ToString()}",
                        item.Cliente,
                        item.Fecha.ToLongDateString(),
                        item.Monto.ToString(),
                        item.Estado,
                        item.Encargado.Nombre,
                        item.AutorPrespuesto,
                        item.EncargadoCotizador
                        );
                }
                dgvOfertas.DataSource = _tabla;

            }
            else
            {

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarOferta agregarOferta = new();
            agregarOferta.ShowDialog();
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }

        }

        private async void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            txtNumeroOferta.Text = string.Empty;
            if (Temporal.TipoLogin.Equals("Administrador"))
            {
                await CargarTablaAdministradores();
            }
            else
            {
                await CargarTablaVendedores();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtNumeroOferta.Text, out int numeroOferta);
                var cliente = (string.IsNullOrEmpty(txtCliente.Text)) ? string.Empty : txtCliente.Text;
                List<Oferta> busqueda = new List<Oferta>(); 
                OfertaNegocio tmp = new OfertaNegocio();
                if (Temporal.TipoLogin.Equals("Administrador"))
                {
                    busqueda = tmp.BuscarOferta(numeroOferta: numeroOferta, Cliente: cliente);
                    CargarTablaAdministradores(busqueda);
                }
                else
                {
                    busqueda = tmp.BuscarOferta(numeroOferta: numeroOferta, Cliente: cliente, idUser: Temporal.UsuarioActivo.UsuarioId);
                    CargarTablaVendedores(busqueda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    // Obtener el id
                    var dato = (dgvOfertas.Rows[e.RowIndex].Cells[2].Value.ToString()).Split('-');
                    var id = int.Parse(dato[1]);
                    VerOferta verOferta = new VerOferta();
                    verOferta.idOferta = id;
                    verOferta.Show();
                }
                else if (e.ColumnIndex == 1)
                {
                    // Obtener el id
                    var dato = (dgvOfertas.Rows[e.RowIndex].Cells[2].Value.ToString()).Split('-');
                    var id = int.Parse(dato[1]);
                    EditarOferta editarOferta = new() { idOferta = id };
                    editarOferta.ShowDialog();
                    if (Temporal.TipoLogin.Equals("Administrador"))
                    {
                        CargarTablaAdministradores();
                    }
                    else
                    {
                        CargarTablaVendedores();
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
