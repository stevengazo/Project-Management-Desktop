namespace Interfaz
{
    partial class EditarProyecto
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
            numericUpDownOfertaID = new NumericUpDown();
            numericUpDownTarea = new NumericUpDown();
            numericUpDownMontoIVA = new NumericUpDown();
            numericUpDownMonto = new NumericUpDown();
            label11 = new Label();
            txtDescripcion = new TextBox();
            label10 = new Label();
            comboBoxTipoMoneda = new ComboBox();
            label9 = new Label();
            txtOrdenCompra = new TextBox();
            label8 = new Label();
            checkBoxPublico = new CheckBox();
            label7 = new Label();
            cbProvincia = new ComboBox();
            label1 = new Label();
            cbTipoTrabajo = new ComboBox();
            label3 = new Label();
            dtpOrdenCompra = new DateTimePicker();
            cbEstado = new ComboBox();
            numericUpDownPorcentaje = new NumericUpDown();
            lblEstado = new Label();
            txtUbicacion = new TextBox();
            label14 = new Label();
            lblTarea = new Label();
            lblPorcentaje = new Label();
            lblMonto = new Label();
            lblOferta = new Label();
            label5 = new Label();
            lblVendedor = new Label();
            txtCedula = new TextBox();
            label19 = new Label();
            btnBorrar = new Button();
            txtRazonSocial = new TextBox();
            txtidProyecto = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            button2 = new Button();
            label4 = new Label();
            comboBoxVendedores = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOfertaID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxVendedores);
            groupBox1.Controls.Add(numericUpDownOfertaID);
            groupBox1.Controls.Add(numericUpDownTarea);
            groupBox1.Controls.Add(numericUpDownMontoIVA);
            groupBox1.Controls.Add(numericUpDownMonto);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBoxTipoMoneda);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtOrdenCompra);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(checkBoxPublico);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbProvincia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbTipoTrabajo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpOrdenCompra);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(numericUpDownPorcentaje);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lblTarea);
            groupBox1.Controls.Add(lblPorcentaje);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(lblOferta);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblVendedor);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(txtidProyecto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 745);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Proyecto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numericUpDownOfertaID
            // 
            numericUpDownOfertaID.Location = new Point(181, 139);
            numericUpDownOfertaID.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownOfertaID.Name = "numericUpDownOfertaID";
            numericUpDownOfertaID.Size = new Size(225, 23);
            numericUpDownOfertaID.TabIndex = 93;
            // 
            // numericUpDownTarea
            // 
            numericUpDownTarea.Location = new Point(181, 533);
            numericUpDownTarea.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownTarea.Name = "numericUpDownTarea";
            numericUpDownTarea.Size = new Size(225, 23);
            numericUpDownTarea.TabIndex = 92;
            // 
            // numericUpDownMontoIVA
            // 
            numericUpDownMontoIVA.DecimalPlaces = 3;
            numericUpDownMontoIVA.Location = new Point(181, 286);
            numericUpDownMontoIVA.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMontoIVA.Name = "numericUpDownMontoIVA";
            numericUpDownMontoIVA.Size = new Size(225, 23);
            numericUpDownMontoIVA.TabIndex = 91;
            numericUpDownMontoIVA.ThousandsSeparator = true;
            // 
            // numericUpDownMonto
            // 
            numericUpDownMonto.DecimalPlaces = 3;
            numericUpDownMonto.Location = new Point(181, 257);
            numericUpDownMonto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownMonto.Name = "numericUpDownMonto";
            numericUpDownMonto.Size = new Size(225, 23);
            numericUpDownMonto.TabIndex = 90;
            numericUpDownMonto.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 373);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 89;
            label11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 373);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(225, 44);
            txtDescripcion.TabIndex = 88;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 286);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 86;
            label10.Text = "Monto IVA";
            // 
            // comboBoxTipoMoneda
            // 
            comboBoxTipoMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMoneda.FormattingEnabled = true;
            comboBoxTipoMoneda.Items.AddRange(new object[] { "Dolar ", "Colón", "Euro", "Yen" });
            comboBoxTipoMoneda.Location = new Point(181, 228);
            comboBoxTipoMoneda.Name = "comboBoxTipoMoneda";
            comboBoxTipoMoneda.Size = new Size(225, 23);
            comboBoxTipoMoneda.TabIndex = 85;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 228);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 84;
            label9.Text = "Tipo Moneda";
            // 
            // txtOrdenCompra
            // 
            txtOrdenCompra.Location = new Point(181, 170);
            txtOrdenCompra.Name = "txtOrdenCompra";
            txtOrdenCompra.Size = new Size(225, 23);
            txtOrdenCompra.TabIndex = 83;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 170);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 82;
            label8.Text = "Orden de Compra";
            // 
            // checkBoxPublico
            // 
            checkBoxPublico.AutoSize = true;
            checkBoxPublico.Location = new Point(181, 116);
            checkBoxPublico.Name = "checkBoxPublico";
            checkBoxPublico.Size = new Size(80, 19);
            checkBoxPublico.TabIndex = 81;
            checkBoxPublico.Text = "Es Público";
            checkBoxPublico.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 116);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 80;
            label7.Text = "Sector";
            // 
            // cbProvincia
            // 
            cbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Limón", "Puntarenas", "Guanacaste", "Internacional" });
            cbProvincia.Location = new Point(181, 423);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(225, 23);
            cbProvincia.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 423);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 78;
            label1.Text = "Provincia";
            // 
            // cbTipoTrabajo
            // 
            cbTipoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTrabajo.FormattingEnabled = true;
            cbTipoTrabajo.Items.AddRange(new object[] { "DDCE - Instalación", "DDCE - Mantenimiento", "DDCE - Mejoras", "Ionizante - Instalación", "Ionizante - Mantenimiento", "Ionizante - Mejoras", "Mallas - Instalación", "Mallas - Mantenimiento", "Mallas - Mejora", "Supresores - Instalación", "Trabajo Eléctrico", "Otro" });
            cbTipoTrabajo.Location = new Point(181, 344);
            cbTipoTrabajo.Name = "cbTipoTrabajo";
            cbTipoTrabajo.Size = new Size(225, 23);
            cbTipoTrabajo.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 344);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 76;
            label3.Text = "Tipo Trabajo";
            // 
            // dtpOrdenCompra
            // 
            dtpOrdenCompra.Location = new Point(181, 199);
            dtpOrdenCompra.Name = "dtpOrdenCompra";
            dtpOrdenCompra.Size = new Size(225, 23);
            dtpOrdenCompra.TabIndex = 74;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            cbEstado.Location = new Point(181, 591);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(225, 23);
            cbEstado.TabIndex = 72;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(181, 315);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 71;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(7, 591);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 70;
            lblEstado.Text = "Estado";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(181, 452);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Canton, Distrito, Direcciones";
            txtUbicacion.Size = new Size(225, 75);
            txtUbicacion.TabIndex = 69;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 452);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 68;
            label14.Text = "Ubicación";
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(7, 533);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(64, 15);
            lblTarea.TabIndex = 66;
            lblTarea.Text = "Tarea Bitrix";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(7, 315);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(111, 15);
            lblPorcentaje.TabIndex = 64;
            lblPorcentaje.Text = "Porcentaje Anticipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(11, 257);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 63;
            lblMonto.Text = "Monto";
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(11, 141);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(77, 15);
            lblOferta.TabIndex = 62;
            lblOferta.Text = "Oferta Mecsa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 199);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 61;
            label5.Text = "Fecha Orden Compra";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(7, 562);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 60;
            lblVendedor.Text = "Vendedor";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(181, 87);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "1111111111111";
            txtCedula.Size = new Size(225, 23);
            txtCedula.TabIndex = 53;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 87);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 52;
            label19.Text = "Cedula";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightCoral;
            btnBorrar.Location = new Point(25, 638);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 23);
            btnBorrar.TabIndex = 41;
            btnBorrar.Text = "Borrar Proyecto";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(181, 58);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(225, 23);
            txtRazonSocial.TabIndex = 6;
            // 
            // txtidProyecto
            // 
            txtidProyecto.Location = new Point(181, 29);
            txtidProyecto.Name = "txtidProyecto";
            txtidProyecto.ReadOnly = true;
            txtidProyecto.Size = new Size(225, 23);
            txtidProyecto.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 32);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 39;
            label6.Text = "Id Interno";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SkyBlue;
            btnAgregar.Location = new Point(264, 638);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Actualizar Proyecto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 638);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "Razon Social";
            // 
            // comboBoxVendedores
            // 
            comboBoxVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVendedores.FormattingEnabled = true;
            comboBoxVendedores.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            comboBoxVendedores.Location = new Point(181, 562);
            comboBoxVendedores.Name = "comboBoxVendedores";
            comboBoxVendedores.Size = new Size(225, 23);
            comboBoxVendedores.TabIndex = 94;
            // 
            // EditarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 769);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarProyecto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Proyecto";
            Load += EditarProyecto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOfertaID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRazonSocial;
        private TextBox txtidProyecto;
        private Label label6;
        private Button btnAgregar;
        private Button button2;
        private Label label4;
        private Button btnBorrar;
        private Label label19;
        private TextBox txtCedula;
        private Label label11;
        private TextBox txtDescripcion;
        private Label label10;
        private ComboBox comboBoxTipoMoneda;
        private Label label9;
        private TextBox txtOrdenCompra;
        private Label label8;
        private CheckBox checkBoxPublico;
        private Label label7;
        private ComboBox cbProvincia;
        private Label label1;
        private ComboBox cbTipoTrabajo;
        private Label label3;
        private DateTimePicker dtpOrdenCompra;
        private ComboBox cbVendedores;
        private ComboBox cbEstado;
        private NumericUpDown numericUpDownPorcentaje;
        private Label lblEstado;
        private TextBox txtUbicacion;
        private Label label14;
        private Label lblTarea;
        private Label lblPorcentaje;
        private Label lblMonto;
        private Label lblOferta;
        private Label label5;
        private Label lblVendedor;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDownMonto;
        private NumericUpDown numericUpDownMontoIVA;
        private NumericUpDown numericUpDownTarea;
        private NumericUpDown numericUpDownOfertaID;
        private ComboBox comboBoxVendedores;
    }
}