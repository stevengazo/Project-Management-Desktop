namespace Interfaz
{
    partial class VerNota
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
            label14 = new Label();
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtUltimaEdicion = new TextBox();
            label3 = new Label();
            txtUltimoEditor = new TextBox();
            label2 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            txtAutor = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 48);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 56;
            label14.Text = "Descripcion";
            label14.Click += label14_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDescripcion.Location = new Point(180, 45);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(225, 200);
            txtDescripcion.TabIndex = 57;
            txtDescripcion.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(180, 16);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(225, 23);
            txtTitulo.TabIndex = 70;
            txtTitulo.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 69;
            label6.Text = "Titulo";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUltimaEdicion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUltimoEditor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label14);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 380);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nota";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(6, 341);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 86;
            label4.Text = "Fecha";
            // 
            // txtUltimaEdicion
            // 
            txtUltimaEdicion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUltimaEdicion.Location = new Point(180, 338);
            txtUltimaEdicion.Name = "txtUltimaEdicion";
            txtUltimaEdicion.ReadOnly = true;
            txtUltimaEdicion.Size = new Size(225, 23);
            txtUltimaEdicion.TabIndex = 85;
            txtUltimaEdicion.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 312);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 84;
            label3.Text = "Ultimo Editor";
            // 
            // txtUltimoEditor
            // 
            txtUltimoEditor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUltimoEditor.Location = new Point(180, 309);
            txtUltimoEditor.Name = "txtUltimoEditor";
            txtUltimoEditor.ReadOnly = true;
            txtUltimoEditor.Size = new Size(225, 23);
            txtUltimoEditor.TabIndex = 83;
            txtUltimoEditor.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(6, 283);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 82;
            label2.Text = "Creación";
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFecha.Location = new Point(180, 280);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(225, 23);
            txtFecha.TabIndex = 81;
            txtFecha.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(6, 254);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 80;
            label1.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtAutor.Location = new Point(180, 251);
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(225, 23);
            txtAutor.TabIndex = 79;
            txtAutor.TextAlign = HorizontalAlignment.Right;
            // 
            // VerNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 403);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(486, 900);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(486, 0);
            Name = "VerNota";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Nota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        private TextBox txtUbicacion;
        private TextBox txtNumeroProyecto;
        private Label label6;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtDescripcion;
        private TextBox txtTitulo;
        private TextBox txtFecha;
        private TextBox txtAutor;
        private Label label4;
        private TextBox txtUltimaEdicion;
        private Label label3;
        private TextBox txtUltimoEditor;
    }
}