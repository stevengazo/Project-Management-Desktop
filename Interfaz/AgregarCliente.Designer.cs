namespace Interfaz
{
	partial class AgregarCliente
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRazon = new System.Windows.Forms.TextBox();
			this.txtNombreComercial = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero de Cedula";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Razón Social";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre Comercial";
			// 
			// txtRazon
			// 
			this.txtRazon.Location = new System.Drawing.Point(146, 47);
			this.txtRazon.Name = "txtRazon";
			this.txtRazon.PlaceholderText = "Ejemplo S.A";
			this.txtRazon.Size = new System.Drawing.Size(228, 23);
			this.txtRazon.TabIndex = 4;
			// 
			// txtNombreComercial
			// 
			this.txtNombreComercial.Location = new System.Drawing.Point(146, 80);
			this.txtNombreComercial.Name = "txtNombreComercial";
			this.txtNombreComercial.PlaceholderText = "Ejemplitos";
			this.txtNombreComercial.Size = new System.Drawing.Size(228, 23);
			this.txtNombreComercial.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(78, 125);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(198, 125);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(146, 12);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.PlaceholderText = "1111111111111";
			this.txtCedula.Size = new System.Drawing.Size(228, 23);
			this.txtCedula.TabIndex = 8;
			// 
			// AgregarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(386, 161);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtNombreComercial);
			this.Controls.Add(this.txtRazon);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AgregarCliente";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtRazon;
		private TextBox txtNombreComercial;
		private Button button1;
		private Button btnAgregar;
		private TextBox txtCedula;
	}
}