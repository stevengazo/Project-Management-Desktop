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
			((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOfertas
			// 
			this.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOfertas.Location = new System.Drawing.Point(12, 27);
			this.dgvOfertas.Name = "dgvOfertas";
			this.dgvOfertas.RowTemplate.Height = 25;
			this.dgvOfertas.Size = new System.Drawing.Size(1213, 556);
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
			// ListarOferta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 595);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvOfertas;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem agregarOfertaToolStripMenuItem;
	}
}