namespace Interfaz
{
    partial class EditarOferta
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            txtEncargado = new TextBox();
            label11 = new Label();
            txtCliente = new TextBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            cbEncargado = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtObservaciones = new TextBox();
            label8 = new Label();
            txtNotas = new TextBox();
            label7 = new Label();
            txtMonto = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtEncargado);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbEncargado);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNotas);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(dateTimePickerFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Ofeta";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 254);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 26;
            label12.Text = "Cotizador";
            // 
            // txtEncargado
            // 
            txtEncargado.Location = new Point(103, 251);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.PlaceholderText = "Adrian ";
            txtEncargado.Size = new Size(184, 23);
            txtEncargado.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 51);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(103, 51);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Pepe";
            txtCliente.Size = new Size(184, 23);
            txtCliente.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(161, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(56, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbEncargado
            // 
            cbEncargado.FormattingEnabled = true;
            cbEncargado.Location = new Point(103, 222);
            cbEncargado.Name = "cbEncargado";
            cbEncargado.Size = new Size(184, 23);
            cbEncargado.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 225);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 19;
            label10.Text = "Encargado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 161);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 17;
            label9.Text = "Descripcion";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(103, 158);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Descripción breve del trabajo";
            txtObservaciones.Size = new Size(184, 53);
            txtObservaciones.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 109);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "Notas";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(103, 109);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.PlaceholderText = "Notas de relevancia, sobre la tarea";
            txtNotas.Size = new Size(184, 33);
            txtNotas.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 80);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(103, 80);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "150000";
            txtMonto.Size = new Size(184, 23);
            txtMonto.TabIndex = 12;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(103, 22);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(184, 23);
            dateTimePickerFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // EditarOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 337);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarOferta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Oferta";
            Load += EditarOferta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label12;
        private TextBox txtEncargado;
        private Label label11;
        private TextBox txtCliente;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cbEncargado;
        private Label label10;
        private Label label9;
        private TextBox txtObservaciones;
        private Label label8;
        private TextBox txtNotas;
        private Label label7;
        private TextBox txtMonto;
        private DateTimePicker dateTimePickerFecha;
        private Label label1;
    }
}