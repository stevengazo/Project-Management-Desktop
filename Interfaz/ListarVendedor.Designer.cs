namespace Interfaz
{
	partial class ListarVendedor
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
			this.txtVendedorNombre = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.dgvVendedores = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
			this.SuspendLayout();
			// 
			// txtVendedorNombre
			// 
			this.txtVendedorNombre.Location = new System.Drawing.Point(12, 12);
			this.txtVendedorNombre.Name = "txtVendedorNombre";
			this.txtVendedorNombre.PlaceholderText = "Nombre Vendedor";
			this.txtVendedorNombre.Size = new System.Drawing.Size(163, 23);
			this.txtVendedorNombre.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(181, 12);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(262, 11);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 2;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// dgvVendedores
			// 
			this.dgvVendedores.AllowUserToAddRows = false;
			this.dgvVendedores.AllowUserToDeleteRows = false;
			this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVendedores.Location = new System.Drawing.Point(12, 59);
			this.dgvVendedores.Name = "dgvVendedores";
			this.dgvVendedores.ReadOnly = true;
			this.dgvVendedores.RowTemplate.Height = 25;
			this.dgvVendedores.Size = new System.Drawing.Size(320, 255);
			this.dgvVendedores.TabIndex = 3;
			// 
			// ListarVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 329);
			this.Controls.Add(this.dgvVendedores);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtVendedorNombre);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarVendedor";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista de Vendedores";
			this.Load += new System.EventHandler(this.ListarVendedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtVendedorNombre;
		private Button btnBuscar;
		private Button btnLimpiar;
		private DataGridView dgvVendedores;
	}
}