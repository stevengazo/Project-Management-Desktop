namespace Interfaz
{
	partial class ListarOferta
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvOfertas = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarOfertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumeroProyecto = new System.Windows.Forms.TextBox();
			this.txtVendedor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.BtnLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOfertas
			// 
			this.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOfertas.Location = new System.Drawing.Point(12, 92);
			this.dgvOfertas.Name = "dgvOfertas";
			this.dgvOfertas.RowTemplate.Height = 25;
			this.dgvOfertas.Size = new System.Drawing.Size(1213, 491);
			this.dgvOfertas.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.agregarOfertaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// agregarOfertaToolStripMenuItem
			// 
			this.agregarOfertaToolStripMenuItem.Name = "agregarOfertaToolStripMenuItem";
			this.agregarOfertaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.agregarOfertaToolStripMenuItem.Text = "Agregar Oferta";
			this.agregarOfertaToolStripMenuItem.Click += new System.EventHandler(this.agregarOfertaToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnLimpar);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.txtCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtVendedor);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNumeroProyecto);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1213, 59);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero de Oferta";
			// 
			// txtNumeroProyecto
			// 
			this.txtNumeroProyecto.Location = new System.Drawing.Point(123, 24);
			this.txtNumeroProyecto.Name = "txtNumeroProyecto";
			this.txtNumeroProyecto.PlaceholderText = "1234565";
			this.txtNumeroProyecto.Size = new System.Drawing.Size(180, 23);
			this.txtNumeroProyecto.TabIndex = 1;
			// 
			// txtVendedor
			// 
			this.txtVendedor.Location = new System.Drawing.Point(427, 24);
			this.txtVendedor.Name = "txtVendedor";
			this.txtVendedor.PlaceholderText = "Vendedor";
			this.txtVendedor.Size = new System.Drawing.Size(180, 23);
			this.txtVendedor.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(318, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vendedor";
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(730, 24);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.PlaceholderText = "Mecsa";
			this.txtCliente.Size = new System.Drawing.Size(180, 23);
			this.txtCliente.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(621, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cliente";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(934, 24);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(105, 23);
			this.btnAgregar.TabIndex = 6;
			this.btnAgregar.Text = "Buscar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// BtnLimpar
			// 
			this.BtnLimpar.Location = new System.Drawing.Point(1065, 24);
			this.BtnLimpar.Name = "BtnLimpar";
			this.BtnLimpar.Size = new System.Drawing.Size(105, 23);
			this.BtnLimpar.TabIndex = 7;
			this.BtnLimpar.Text = "Limpiar";
			this.BtnLimpar.UseVisualStyleBackColor = true;
			this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
			// 
			// ListarOferta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 595);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvOfertas);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarOferta";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista de Ofertas";
			this.Load += new System.EventHandler(this.ListarOferta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvOfertas;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem agregarOfertaToolStripMenuItem;
		private GroupBox groupBox1;
		private Button BtnLimpar;
		private Button btnAgregar;
		private TextBox txtCliente;
		private Label label3;
		private TextBox txtVendedor;
		private Label label2;
		private TextBox txtNumeroProyecto;
		private Label label1;
	}
}