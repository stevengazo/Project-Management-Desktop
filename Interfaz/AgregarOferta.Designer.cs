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
            label1 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            txtMonto = new TextBox();
            label7 = new Label();
            txtNotas = new TextBox();
            label8 = new Label();
            txtObservaciones = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cbEncargado = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtCliente = new TextBox();
            label11 = new Label();
            txtEncargado = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            comboBoxProvincia = new ComboBox();
            label4 = new Label();
            comboBoxCategoria = new ComboBox();
            label3 = new Label();
            checkBoxOtro = new CheckBox();
            checkBoxMalla = new CheckBox();
            checkBoxTorre = new CheckBox();
            checkBoxSupresor = new CheckBox();
            checkBoxIonizante = new CheckBox();
            label2 = new Label();
            checkBoxDDCE = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(103, 22);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(184, 23);
            dateTimePickerFecha.TabIndex = 1;
            dateTimePickerFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(106, 197);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "150000";
            txtMonto.Size = new Size(184, 23);
            txtMonto.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 200);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Monto";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(106, 226);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.PlaceholderText = "Notas e información varia";
            txtNotas.Size = new Size(184, 53);
            txtNotas.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 229);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "Notas";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(106, 288);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Descripción y ubicación";
            txtObservaciones.Size = new Size(184, 53);
            txtObservaciones.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 288);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 17;
            label9.Text = "Descripcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 379);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 19;
            label10.Text = "Vendedor";
            // 
            // cbEncargado
            // 
            cbEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEncargado.FormattingEnabled = true;
            cbEncargado.Location = new Point(106, 376);
            cbEncargado.Name = "cbEncargado";
            cbEncargado.Size = new Size(184, 23);
            cbEncargado.TabIndex = 20;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 438);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(165, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(103, 52);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Pepe";
            txtCliente.Size = new Size(184, 23);
            txtCliente.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 52);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "Cliente";
            // 
            // txtEncargado
            // 
            txtEncargado.Location = new Point(106, 405);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.PlaceholderText = "Adrián Sólis";
            txtEncargado.Size = new Size(184, 23);
            txtEncargado.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 408);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 26;
            label12.Text = "Cotizado por";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxProvincia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBoxOtro);
            groupBox1.Controls.Add(checkBoxMalla);
            groupBox1.Controls.Add(checkBoxTorre);
            groupBox1.Controls.Add(checkBoxSupresor);
            groupBox1.Controls.Add(checkBoxIonizante);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBoxDDCE);
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
            groupBox1.Size = new Size(309, 479);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Ofeta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxProvincia
            // 
            comboBoxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvincia.FormattingEnabled = true;
            comboBoxProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Puntarenas", "Guanacaste", "Limón", "No definido", "Internacional" });
            comboBoxProvincia.Location = new Point(106, 347);
            comboBoxProvincia.Name = "comboBoxProvincia";
            comboBoxProvincia.Size = new Size(184, 23);
            comboBoxProvincia.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 350);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 36;
            label4.Text = "Provincia";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Instalación", "Mantenimiento", "Mejora", "Otro" });
            comboBoxCategoria.Location = new Point(103, 166);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(184, 23);
            comboBoxCategoria.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 169);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 34;
            label3.Text = "Categoria";
            // 
            // checkBoxOtro
            // 
            checkBoxOtro.AutoSize = true;
            checkBoxOtro.Location = new Point(190, 141);
            checkBoxOtro.Name = "checkBoxOtro";
            checkBoxOtro.Size = new Size(50, 19);
            checkBoxOtro.TabIndex = 33;
            checkBoxOtro.Text = "Otro";
            checkBoxOtro.UseVisualStyleBackColor = true;
            // 
            // checkBoxMalla
            // 
            checkBoxMalla.AutoSize = true;
            checkBoxMalla.Location = new Point(103, 141);
            checkBoxMalla.Name = "checkBoxMalla";
            checkBoxMalla.Size = new Size(55, 19);
            checkBoxMalla.TabIndex = 32;
            checkBoxMalla.Text = "Malla";
            checkBoxMalla.UseVisualStyleBackColor = true;
            // 
            // checkBoxTorre
            // 
            checkBoxTorre.AutoSize = true;
            checkBoxTorre.Location = new Point(190, 116);
            checkBoxTorre.Name = "checkBoxTorre";
            checkBoxTorre.Size = new Size(52, 19);
            checkBoxTorre.TabIndex = 31;
            checkBoxTorre.Text = "Torre";
            checkBoxTorre.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupresor
            // 
            checkBoxSupresor.AutoSize = true;
            checkBoxSupresor.Location = new Point(103, 116);
            checkBoxSupresor.Name = "checkBoxSupresor";
            checkBoxSupresor.Size = new Size(72, 19);
            checkBoxSupresor.TabIndex = 30;
            checkBoxSupresor.Text = "Supresor";
            checkBoxSupresor.UseVisualStyleBackColor = true;
            // 
            // checkBoxIonizante
            // 
            checkBoxIonizante.AutoSize = true;
            checkBoxIonizante.Location = new Point(190, 91);
            checkBoxIonizante.Name = "checkBoxIonizante";
            checkBoxIonizante.Size = new Size(74, 19);
            checkBoxIonizante.TabIndex = 29;
            checkBoxIonizante.Text = "Ionizante";
            checkBoxIonizante.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 28;
            label2.Text = "Requiere: ";
            label2.Click += label2_Click;
            // 
            // checkBoxDDCE
            // 
            checkBoxDDCE.AutoSize = true;
            checkBoxDDCE.Location = new Point(103, 91);
            checkBoxDDCE.Name = "checkBoxDDCE";
            checkBoxDDCE.Size = new Size(56, 19);
            checkBoxDDCE.TabIndex = 27;
            checkBoxDDCE.Text = "DDCE";
            checkBoxDDCE.UseVisualStyleBackColor = true;
            // 
            // AgregarOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 497);
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

        private Label label1;
        private DateTimePicker dateTimePickerFecha;
        private TextBox txtMonto;
        private Label label7;
        private TextBox txtNotas;
        private Label label8;
        private TextBox txtObservaciones;
        private Label label9;
        private Label label10;
        private ComboBox cbEncargado;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtCliente;
        private Label label11;
        private TextBox txtEncargado;
        private Label label12;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox checkBoxDDCE;
        private CheckBox checkBoxMalla;
        private CheckBox checkBoxTorre;
        private CheckBox checkBoxSupresor;
        private CheckBox checkBoxIonizante;
        private ComboBox comboBoxCategoria;
        private Label label3;
        private CheckBox checkBoxOtro;
        private ComboBox comboBoxProvincia;
        private Label label4;
    }
}