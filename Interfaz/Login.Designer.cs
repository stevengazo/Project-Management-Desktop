namespace Interfaz
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.lblErrorMessage = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(59, 43);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(191, 23);
			this.txtUsuario.TabIndex = 0;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(59, 94);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(191, 23);
			this.txtContrasena.TabIndex = 1;
			this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblErrorMessage
			// 
			this.lblErrorMessage.AutoSize = true;
			this.lblErrorMessage.Location = new System.Drawing.Point(76, 129);
			this.lblErrorMessage.Name = "lblErrorMessage";
			this.lblErrorMessage.Size = new System.Drawing.Size(0, 15);
			this.lblErrorMessage.TabIndex = 2;
			this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(105, 150);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(95, 23);
			this.btnIngresar.TabIndex = 3;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(124, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuario";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(112, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Contrasena";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(309, 207);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lblErrorMessage);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtUsuario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtUsuario;
		private TextBox txtContrasena;
		private Label lblErrorMessage;
		private Button btnIngresar;
		private Label label2;
		private Label label3;
	}
}