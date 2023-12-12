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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblErrorMessage = new Label();
            btnIngresar = new Button();
            label2 = new Label();
            label3 = new Label();
            cbTipo = new ComboBox();
            checkBoxContrasena = new CheckBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(59, 43);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(59, 94);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(191, 23);
            txtContrasena.TabIndex = 1;
            txtContrasena.TextAlign = HorizontalAlignment.Center;
            txtContrasena.KeyDown += txtContrasena_KeyDown;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(73, 151);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 15);
            lblErrorMessage.TabIndex = 2;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(106, 203);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(95, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(124, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(112, 69);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Contrasena";
            label3.Click += label3_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(99, 130);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(125, 23);
            cbTipo.TabIndex = 6;
            cbTipo.Text = "Vendedor";
            // 
            // checkBoxContrasena
            // 
            checkBoxContrasena.AutoSize = true;
            checkBoxContrasena.ForeColor = SystemColors.ButtonFace;
            checkBoxContrasena.Location = new Point(112, 165);
            checkBoxContrasena.Name = "checkBoxContrasena";
            checkBoxContrasena.Size = new Size(106, 19);
            checkBoxContrasena.TabIndex = 7;
            checkBoxContrasena.Text = "Recordar Datos";
            checkBoxContrasena.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(309, 238);
            Controls.Add(checkBoxContrasena);
            Controls.Add(cbTipo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(lblErrorMessage);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            KeyUp += Login_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblErrorMessage;
        private Button btnIngresar;
        private Label label2;
        private Label label3;
        private ComboBox cbTipo;
        private CheckBox checkBoxContrasena;
    }
}