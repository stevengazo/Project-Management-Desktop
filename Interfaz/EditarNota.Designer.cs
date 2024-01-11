namespace Interfaz
{
    partial class EditarNota
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
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            label12 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 213);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(181, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 23);
            btnAgregar.TabIndex = 83;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 66);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 85;
            label12.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 84;
            label2.Text = "Titulo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 66);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 98);
            txtDescripcion.TabIndex = 83;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(106, 22);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(177, 23);
            txtTitulo.TabIndex = 0;
            // 
            // EditarNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 246);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(338, 285);
            Name = "EditarNota";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Nota";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnAgregar;
        private Label label12;
        private Label label2;
        private TextBox txtDescripcion;
        private TextBox txtTitulo;
    }
}