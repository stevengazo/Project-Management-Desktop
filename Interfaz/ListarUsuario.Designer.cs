namespace Interfaz
{
	partial class ListarUsuario
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
			dgvUsuarios = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
			SuspendLayout();
			// 
			// dgvUsuarios
			// 
			dgvUsuarios.AllowUserToAddRows = false;
			dgvUsuarios.AllowUserToDeleteRows = false;
			dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUsuarios.Location = new Point(12, 12);
			dgvUsuarios.Name = "dgvUsuarios";
			dgvUsuarios.ReadOnly = true;
			dgvUsuarios.RowTemplate.Height = 25;
			dgvUsuarios.Size = new Size(1130, 490);
			dgvUsuarios.TabIndex = 0;
			dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
			// 
			// ListarUsuario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1154, 514);
			Controls.Add(dgvUsuarios);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ListarUsuario";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Listar Usuario";
			Load += ListarUsuario_Load;
			((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvUsuarios;
	}
}