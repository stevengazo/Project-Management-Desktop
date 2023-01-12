namespace Interfaz
{
	partial class ListarCliente
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
			this.dgvCliente = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCliente
			// 
			this.dgvCliente.AllowUserToAddRows = false;
			this.dgvCliente.AllowUserToDeleteRows = false;
			this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCliente.Location = new System.Drawing.Point(12, 59);
			this.dgvCliente.Name = "dgvCliente";
			this.dgvCliente.ReadOnly = true;
			this.dgvCliente.RowTemplate.Height = 25;
			this.dgvCliente.Size = new System.Drawing.Size(557, 379);
			this.dgvCliente.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Razón";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(67, 19);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(118, 23);
			this.txtRazonSocial.TabIndex = 2;
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(249, 19);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(118, 23);
			this.txtCedula.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(194, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cedula";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(373, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(454, 19);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// ListarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 450);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRazonSocial);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCliente);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarCliente";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista de Clientes";
			this.Load += new System.EventHandler(this.ListarCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvCliente;
		private Label label1;
		private TextBox txtRazonSocial;
		private TextBox txtCedula;
		private Label label2;
		private Button btnBuscar;
		private Button btnLimpiar;
	}
}