namespace Interfaz
{
    partial class ModuloVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloVentas));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            agregarCotizaciónToolStripMenuItem = new ToolStripMenuItem();
            verCotizacionesToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
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
            txtCedula = new TextBox();
            label6 = new Label();
            cbProvincia = new ComboBox();
            label4 = new Label();
            cbTipoTrabajo = new ComboBox();
            label3 = new Label();
            txtNombreCliente = new TextBox();
            dtpOrdenCompra = new DateTimePicker();
            cbVendedores = new ComboBox();
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
            lblRazon = new Label();
            lblVendedor = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            limpar = new Button();
            btnBuscar = new Button();
            txtNumeroPBuscar = new TextBox();
            label2 = new Label();
            txtClienteBuscar = new TextBox();
            label1 = new Label();
            dgvProyectos = new DataGridView();
            saveFileDialog = new SaveFileDialog();
            numericUpDownTarea = new NumericUpDown();
            numericUpDownOferta = new NumericUpDown();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOferta).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ofertasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1336, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem });
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(118, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(101, 22);
            excelToolStripMenuItem.Text = "Excel";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(115, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(118, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ofertasToolStripMenuItem
            // 
            ofertasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarCotizaciónToolStripMenuItem, verCotizacionesToolStripMenuItem });
            ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            ofertasToolStripMenuItem.Size = new Size(60, 20);
            ofertasToolStripMenuItem.Text = "Ofertas ";
            // 
            // agregarCotizaciónToolStripMenuItem
            // 
            agregarCotizaciónToolStripMenuItem.Name = "agregarCotizaciónToolStripMenuItem";
            agregarCotizaciónToolStripMenuItem.Size = new Size(175, 22);
            agregarCotizaciónToolStripMenuItem.Text = "Agregar Cotización";
            agregarCotizaciónToolStripMenuItem.Click += agregarCotizaciónToolStripMenuItem_Click;
            // 
            // verCotizacionesToolStripMenuItem
            // 
            verCotizacionesToolStripMenuItem.Name = "verCotizacionesToolStripMenuItem";
            verCotizacionesToolStripMenuItem.Size = new Size(175, 22);
            verCotizacionesToolStripMenuItem.Text = "Ver Cotizaciones";
            verCotizacionesToolStripMenuItem.Click += verCotizacionesToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownOferta);
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
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbProvincia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbTipoTrabajo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(dtpOrdenCompra);
            groupBox1.Controls.Add(cbVendedores);
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
            groupBox1.Controls.Add(lblRazon);
            groupBox1.Controls.Add(lblVendedor);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 639);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Proyecto";
            // 
            // numericUpDownMontoIVA
            // 
            numericUpDownMontoIVA.DecimalPlaces = 3;
            numericUpDownMontoIVA.Location = new Point(190, 255);
            numericUpDownMontoIVA.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownMontoIVA.Name = "numericUpDownMontoIVA";
            numericUpDownMontoIVA.Size = new Size(225, 23);
            numericUpDownMontoIVA.TabIndex = 95;
            numericUpDownMontoIVA.ThousandsSeparator = true;
            // 
            // numericUpDownMonto
            // 
            numericUpDownMonto.DecimalPlaces = 3;
            numericUpDownMonto.Location = new Point(190, 226);
            numericUpDownMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMonto.Name = "numericUpDownMonto";
            numericUpDownMonto.Size = new Size(225, 23);
            numericUpDownMonto.TabIndex = 94;
            numericUpDownMonto.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 342);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 93;
            label11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(190, 342);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(225, 44);
            txtDescripcion.TabIndex = 92;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 255);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 91;
            label10.Text = "Monto IVA";
            // 
            // comboBoxTipoMoneda
            // 
            comboBoxTipoMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMoneda.FormattingEnabled = true;
            comboBoxTipoMoneda.Items.AddRange(new object[] { "Dolar ", "Colón", "Euro", "Yen" });
            comboBoxTipoMoneda.Location = new Point(190, 197);
            comboBoxTipoMoneda.Name = "comboBoxTipoMoneda";
            comboBoxTipoMoneda.Size = new Size(225, 23);
            comboBoxTipoMoneda.TabIndex = 90;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 197);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 89;
            label9.Text = "Tipo Moneda";
            // 
            // txtOrdenCompra
            // 
            txtOrdenCompra.Location = new Point(190, 139);
            txtOrdenCompra.Name = "txtOrdenCompra";
            txtOrdenCompra.Size = new Size(225, 23);
            txtOrdenCompra.TabIndex = 88;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 139);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 87;
            label8.Text = "Orden de Compra";
            // 
            // checkBoxPublico
            // 
            checkBoxPublico.AutoSize = true;
            checkBoxPublico.Location = new Point(187, 85);
            checkBoxPublico.Name = "checkBoxPublico";
            checkBoxPublico.Size = new Size(80, 19);
            checkBoxPublico.TabIndex = 86;
            checkBoxPublico.Text = "Es Público";
            checkBoxPublico.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 85);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 85;
            label7.Text = "Sector";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(190, 56);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "111111111111111";
            txtCedula.Size = new Size(225, 23);
            txtCedula.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 56);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 83;
            label6.Text = "Cedula";
            // 
            // cbProvincia
            // 
            cbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Limón", "Puntarenas", "Guanacaste", "Internacional" });
            cbProvincia.Location = new Point(190, 392);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(225, 23);
            cbProvincia.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 392);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 81;
            label4.Text = "Provincia";
            // 
            // cbTipoTrabajo
            // 
            cbTipoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTrabajo.FormattingEnabled = true;
            cbTipoTrabajo.Items.AddRange(new object[] { "DDCE - Instalación", "DDCE - Mantenimiento", "DDCE - Mejoras", "Ionizante - Instalación", "Ionizante - Mantenimiento", "Ionizante - Mejoras", "Mallas - Instalación", "Mallas - Mantenimiento", "Mallas - Mejora", "Supresores - Instalación", "Trabajo Eléctrico", "Otro" });
            cbTipoTrabajo.Location = new Point(190, 313);
            cbTipoTrabajo.Name = "cbTipoTrabajo";
            cbTipoTrabajo.Size = new Size(225, 23);
            cbTipoTrabajo.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 313);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 79;
            label3.Text = "Tipo Trabajo";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(190, 24);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Ejemplo S.A";
            txtNombreCliente.Size = new Size(225, 23);
            txtNombreCliente.TabIndex = 77;
            // 
            // dtpOrdenCompra
            // 
            dtpOrdenCompra.Location = new Point(190, 168);
            dtpOrdenCompra.Name = "dtpOrdenCompra";
            dtpOrdenCompra.Size = new Size(225, 23);
            dtpOrdenCompra.TabIndex = 76;
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(190, 531);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(225, 23);
            cbVendedores.TabIndex = 75;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            cbEstado.Location = new Point(190, 560);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(225, 23);
            cbEstado.TabIndex = 74;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(190, 284);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 73;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(13, 560);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 72;
            lblEstado.Text = "Estado";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(190, 421);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Canton, Distrito, Direcciones";
            txtUbicacion.Size = new Size(225, 75);
            txtUbicacion.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 421);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 70;
            label14.Text = "Ubicación";
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(13, 502);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(64, 15);
            lblTarea.TabIndex = 68;
            lblTarea.Text = "Tarea Bitrix";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(13, 284);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(111, 15);
            lblPorcentaje.TabIndex = 67;
            lblPorcentaje.Text = "Porcentaje Anticipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(17, 226);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 66;
            lblMonto.Text = "Monto";
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(17, 110);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(77, 15);
            lblOferta.TabIndex = 65;
            lblOferta.Text = "Oferta Mecsa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 168);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 64;
            label5.Text = "Fecha Orden Compra";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(17, 29);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(73, 15);
            lblRazon.TabIndex = 63;
            lblRazon.Text = "Razon Social";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(13, 531);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 62;
            lblVendedor.Text = "Vendedor";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(243, 600);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(144, 600);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(limpar);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtNumeroPBuscar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtClienteBuscar);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvProyectos);
            groupBox2.Location = new Point(447, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(877, 639);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proyectos";
            // 
            // limpar
            // 
            limpar.Location = new Point(620, 29);
            limpar.Name = "limpar";
            limpar.Size = new Size(141, 23);
            limpar.TabIndex = 6;
            limpar.Text = "Limpiar ";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(473, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNumeroPBuscar
            // 
            txtNumeroPBuscar.Location = new Point(365, 29);
            txtNumeroPBuscar.Name = "txtNumeroPBuscar";
            txtNumeroPBuscar.Size = new Size(102, 23);
            txtNumeroPBuscar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 32);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero de Proyecto";
            // 
            // txtClienteBuscar
            // 
            txtClienteBuscar.Location = new Point(56, 29);
            txtClienteBuscar.Name = "txtClienteBuscar";
            txtClienteBuscar.Size = new Size(163, 23);
            txtClienteBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // dgvProyectos
            // 
            dgvProyectos.AllowUserToAddRows = false;
            dgvProyectos.AllowUserToDeleteRows = false;
            dgvProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Location = new Point(6, 61);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowTemplate.Height = 25;
            dgvProyectos.Size = new Size(865, 572);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // numericUpDownTarea
            // 
            numericUpDownTarea.Location = new Point(190, 502);
            numericUpDownTarea.Name = "numericUpDownTarea";
            numericUpDownTarea.Size = new Size(225, 23);
            numericUpDownTarea.TabIndex = 96;
            // 
            // numericUpDownOferta
            // 
            numericUpDownOferta.Location = new Point(190, 110);
            numericUpDownOferta.Name = "numericUpDownOferta";
            numericUpDownOferta.Size = new Size(225, 23);
            numericUpDownOferta.TabIndex = 97;
            // 
            // ModuloVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1336, 678);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ModuloVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo Ventas ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOferta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Button btnLimpiar;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtNumeroPBuscar;
        private Label label2;
        private Label label1;
        private DataGridView dgvProyectos;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem ofertasToolStripMenuItem;
        private ToolStripMenuItem agregarCotizaciónToolStripMenuItem;
        private ToolStripMenuItem verCotizacionesToolStripMenuItem;
        private TextBox txtClienteBuscar;
        private Button limpar;
        private NumericUpDown numericUpDownMontoIVA;
        private NumericUpDown numericUpDownMonto;
        private Label label11;
        private TextBox txtDescripcion;
        private Label label10;
        private ComboBox comboBoxTipoMoneda;
        private Label label9;
        private TextBox txtOrdenCompra;
        private Label label8;
        private CheckBox checkBoxPublico;
        private Label label7;
        private TextBox txtCedula;
        private Label label6;
        private ComboBox cbProvincia;
        private Label label4;
        private ComboBox cbTipoTrabajo;
        private Label label3;
        private TextBox txtNombreCliente;
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
        private Label lblRazon;
        private Label lblVendedor;
        private NumericUpDown numericUpDownOferta;
        private NumericUpDown numericUpDownTarea;
    }
}