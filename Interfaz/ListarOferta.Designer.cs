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
			this.BtnLimpar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumeroOferta = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.txtCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtNumeroOferta);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1213, 59);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// BtnLimpar
			// 
			this.BtnLimpar.Location = new System.Drawing.Point(756, 24);
			this.BtnLimpar.Name = "BtnLimpar";
			this.BtnLimpar.Size = new System.Drawing.Size(105, 23);
			this.BtnLimpar.TabIndex = 7;
			this.BtnLimpar.Text = "Limpiar";
			this.BtnLimpar.UseVisualStyleBackColor = true;
			this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(632, 24);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(105, 23);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(396, 24);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.PlaceholderText = "Mecsa";
			this.txtCliente.Size = new System.Drawing.Size(180, 23);
			this.txtCliente.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(329, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cliente";
			// 
			// txtNumeroOferta
			// 
			this.txtNumeroOferta.Location = new System.Drawing.Point(123, 24);
			this.txtNumeroOferta.Name = "txtNumeroOferta";
			this.txtNumeroOferta.PlaceholderText = "1234565";
			this.txtNumeroOferta.Size = new System.Drawing.Size(180, 23);
			this.txtNumeroOferta.TabIndex = 1;
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
		private Button btnBuscar;
		private TextBox txtCliente;
		private Label label3;
		private TextBox txtNumeroOferta;
		private Label label1;
	}
}