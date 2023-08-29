namespace Interfaz
{
    partial class AgregarOferta
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
            label13 = new Label();
            ckdemarcado = new CheckBox();
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
            checkBoxExcavacion = new CheckBox();
            label6 = new Label();
            checkBoxSubbase = new CheckBox();
            label5 = new Label();
            checkBoxBase = new CheckBox();
            label4 = new Label();
            checkBoxAsfalto = new CheckBox();
            label3 = new Label();
            checkBoxSellador = new CheckBox();
            label2 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(ckdemarcado);
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
            groupBox1.Controls.Add(checkBoxExcavacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkBoxSubbase);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBoxBase);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBoxAsfalto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBoxSellador);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Ofeta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 173);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 28;
            label13.Text = "Demarcado";
            // 
            // ckdemarcado
            // 
            ckdemarcado.AutoSize = true;
            ckdemarcado.Location = new Point(103, 173);
            ckdemarcado.Name = "ckdemarcado";
            ckdemarcado.Size = new Size(143, 19);
            ckdemarcado.TabIndex = 27;
            ckdemarcado.Text = "Necesita demarcación";
            ckdemarcado.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 422);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 26;
            label12.Text = "Cotizador";
            // 
            // txtEncargado
            // 
            txtEncargado.Location = new Point(103, 419);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.PlaceholderText = "Adrián Sólis";
            txtEncargado.Size = new Size(184, 23);
            txtEncargado.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 195);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(103, 198);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Pepe";
            txtCliente.Size = new Size(184, 23);
            txtCliente.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(162, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(57, 452);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbEncargado
            // 
            cbEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEncargado.FormattingEnabled = true;
            cbEncargado.Location = new Point(103, 390);
            cbEncargado.Name = "cbEncargado";
            cbEncargado.Size = new Size(184, 23);
            cbEncargado.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 393);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 19;
            label10.Text = "Encargado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 329);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 17;
            label9.Text = "Descripcion";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(103, 326);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Descripción y ubicación";
            txtObservaciones.Size = new Size(184, 53);
            txtObservaciones.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 261);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "Notas";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(103, 264);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.PlaceholderText = "Notas e información varia";
            txtNotas.Size = new Size(184, 53);
            txtNotas.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 232);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(103, 235);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "150000";
            txtMonto.Size = new Size(184, 23);
            txtMonto.TabIndex = 12;
            // 
            // checkBoxExcavacion
            // 
            checkBoxExcavacion.AutoSize = true;
            checkBoxExcavacion.Location = new Point(103, 151);
            checkBoxExcavacion.Name = "checkBoxExcavacion";
            checkBoxExcavacion.Size = new Size(133, 19);
            checkBoxExcavacion.TabIndex = 11;
            checkBoxExcavacion.Text = "Necesita Excavación";
            checkBoxExcavacion.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 146);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Excavación";
            // 
            // checkBoxSubbase
            // 
            checkBoxSubbase.AutoSize = true;
            checkBoxSubbase.Location = new Point(103, 126);
            checkBoxSubbase.Name = "checkBoxSubbase";
            checkBoxSubbase.Size = new Size(110, 19);
            checkBoxSubbase.TabIndex = 9;
            checkBoxSubbase.Text = "Aplicar Subbase";
            checkBoxSubbase.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 121);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Subbase";
            // 
            // checkBoxBase
            // 
            checkBoxBase.AutoSize = true;
            checkBoxBase.Location = new Point(103, 101);
            checkBoxBase.Name = "checkBoxBase";
            checkBoxBase.Size = new Size(90, 19);
            checkBoxBase.TabIndex = 7;
            checkBoxBase.Text = "Aplicar Base";
            checkBoxBase.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 96);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Base";
            // 
            // checkBoxAsfalto
            // 
            checkBoxAsfalto.AutoSize = true;
            checkBoxAsfalto.Location = new Point(103, 76);
            checkBoxAsfalto.Name = "checkBoxAsfalto";
            checkBoxAsfalto.Size = new Size(103, 19);
            checkBoxAsfalto.TabIndex = 5;
            checkBoxAsfalto.Text = "Aplicar Asfalto";
            checkBoxAsfalto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Asfalto";
            // 
            // checkBoxSellador
            // 
            checkBoxSellador.AutoSize = true;
            checkBoxSellador.Location = new Point(103, 51);
            checkBoxSellador.Name = "checkBoxSellador";
            checkBoxSellador.Size = new Size(108, 19);
            checkBoxSellador.TabIndex = 3;
            checkBoxSellador.Text = "Aplicar Sellador";
            checkBoxSellador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Sellador";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(103, 22);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(184, 23);
            dateTimePickerFecha.TabIndex = 1;
            dateTimePickerFecha.ValueChanged += dateTimePicker1_ValueChanged;
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
            // AgregarOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 499);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarOferta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Oferta";
            Load += AgregarOferta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerFecha;
        private Label label1;
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
        private CheckBox checkBoxExcavacion;
        private Label label6;
        private CheckBox checkBoxSubbase;
        private Label label5;
        private CheckBox checkBoxBase;
        private Label label4;
        private CheckBox checkBoxAsfalto;
        private Label label3;
        private CheckBox checkBoxSellador;
        private Label label2;
        private Label label11;
        private TextBox txtCliente;
        private Label label12;
        private TextBox txtEncargado;
        private Label label13;
        private CheckBox ckdemarcado;
    }
}