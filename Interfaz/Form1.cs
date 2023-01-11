namespace Interfaz
{
	public partial class Form1 : Form
	{		

		public Form1()
		{
			InitializeComponent();
		}

		private void agregarRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCliente tmp1= new AgregarCliente();
			tmp1.ShowDialog();
			// Actualizar combobox
		}

		private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarVendedor tmp1 = new AgregarVendedor();
			tmp1.ShowDialog();
			// Actualizar lista de Vendedores
		}
	}
}