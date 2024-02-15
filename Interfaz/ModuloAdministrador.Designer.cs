namespace Interfaz
{
    partial class ModuloAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloAdministrador));
            groupBox2 = new GroupBox();
            btnLimpiarBusqueda = new Button();
            btnBuscar = new Button();
            txtNumeroProyectoBuscar = new TextBox();
            label2 = new Label();
            txtNombreBuscar = new TextBox();
            label1 = new Label();
            dgvProyectos = new DataGridView();
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
            btnAgregar = new Button();
            button2 = new Button();
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            listarOfertasToolStripMenuItem = new ToolStripMenuItem();
            agregarOfertaToolStripMenuItem = new ToolStripMenuItem();
            cotizacionesToolStripMenuItem = new ToolStripMenuItem();
            resumenToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            listaDeInformesToolStripMenuItem = new ToolStripMenuItem();
            informesPendientesToolStripMenuItem = new ToolStripMenuItem();
            crearInformeToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripDropDownMenu();
            saveFileDialog1 = new SaveFileDialog();
            numericUpDownTarea = new NumericUpDown();
            numericUpDownOferta = new NumericUpDown();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOferta).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnLimpiarBusqueda);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtNumeroProyectoBuscar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNombreBuscar);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvProyectos);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(435, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 711);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proyectos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnLimpiarBusqueda
            // 
            btnLimpiarBusqueda.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarBusqueda.Location = new Point(620, 28);
            btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            btnLimpiarBusqueda.Size = new Size(141, 23);
            btnLimpiarBusqueda.TabIndex = 6;
            btnLimpiarBusqueda.Text = "Limpiar";
            btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            btnLimpiarBusqueda.Click += btnLimpiarBusqueda_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(473, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNumeroProyectoBuscar
            // 
            txtNumeroProyectoBuscar.Location = new Point(365, 29);
            txtNumeroProyectoBuscar.Name = "txtNumeroProyectoBuscar";
            txtNumeroProyectoBuscar.PlaceholderText = "1242";
            txtNumeroProyectoBuscar.Size = new Size(102, 23);
            txtNumeroProyectoBuscar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(242, 32);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero de Proyecto";
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(56, 29);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.PlaceholderText = "Mecsa";
            txtNombreBuscar.Size = new Size(163, 23);
            txtNombreBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
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
            dgvProyectos.Location = new Point(6, 56);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowTemplate.Height = 25;
            dgvProyectos.Size = new Size(912, 643);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
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
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(button2);
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
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(0, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 714);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Proyecto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numericUpDownMontoIVA
            // 
            numericUpDownMontoIVA.DecimalPlaces = 3;
            numericUpDownMontoIVA.Location = new Point(189, 258);
            numericUpDownMontoIVA.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownMontoIVA.Name = "numericUpDownMontoIVA";
            numericUpDownMontoIVA.Size = new Size(225, 23);
            numericUpDownMontoIVA.TabIndex = 61;
            numericUpDownMontoIVA.ThousandsSeparator = true;
            // 
            // numericUpDownMonto
            // 
            numericUpDownMonto.DecimalPlaces = 3;
            numericUpDownMonto.Location = new Point(189, 229);
            numericUpDownMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMonto.Name = "numericUpDownMonto";
            numericUpDownMonto.Size = new Size(225, 23);
            numericUpDownMonto.TabIndex = 60;
            numericUpDownMonto.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 345);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 59;
            label11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(189, 345);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(225, 44);
            txtDescripcion.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 258);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 56;
            label10.Text = "Monto IVA";
            // 
            // comboBoxTipoMoneda
            // 
            comboBoxTipoMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoMoneda.FormattingEnabled = true;
            comboBoxTipoMoneda.Items.AddRange(new object[] { "Dolar ", "Colón", "Euro", "Yen" });
            comboBoxTipoMoneda.Location = new Point(189, 200);
            comboBoxTipoMoneda.Name = "comboBoxTipoMoneda";
            comboBoxTipoMoneda.Size = new Size(225, 23);
            comboBoxTipoMoneda.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 200);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 54;
            label9.Text = "Tipo Moneda";
            // 
            // txtOrdenCompra
            // 
            txtOrdenCompra.Location = new Point(189, 142);
            txtOrdenCompra.Name = "txtOrdenCompra";
            txtOrdenCompra.Size = new Size(225, 23);
            txtOrdenCompra.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 142);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 52;
            label8.Text = "Orden de Compra";
            // 
            // checkBoxPublico
            // 
            checkBoxPublico.AutoSize = true;
            checkBoxPublico.Location = new Point(189, 88);
            checkBoxPublico.Name = "checkBoxPublico";
            checkBoxPublico.Size = new Size(80, 19);
            checkBoxPublico.TabIndex = 51;
            checkBoxPublico.Text = "Es Público";
            checkBoxPublico.UseVisualStyleBackColor = true;
            checkBoxPublico.CheckedChanged += checkBoxPublico_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 88);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 50;
            label7.Text = "Sector";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(189, 59);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "111111111111111";
            txtCedula.Size = new Size(225, 23);
            txtCedula.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 59);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 48;
            label6.Text = "Cedula";
            // 
            // cbProvincia
            // 
            cbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Limón", "Puntarenas", "Guanacaste", "Internacional" });
            cbProvincia.Location = new Point(189, 395);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(225, 23);
            cbProvincia.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 395);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 46;
            label4.Text = "Provincia";
            // 
            // cbTipoTrabajo
            // 
            cbTipoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTrabajo.FormattingEnabled = true;
            cbTipoTrabajo.Items.AddRange(new object[] { "DDCE - Instalación", "DDCE - Mantenimiento", "DDCE - Mejoras", "Ionizante - Instalación", "Ionizante - Mantenimiento", "Ionizante - Mejoras", "Mallas - Instalación", "Mallas - Mantenimiento", "Mallas - Mejora", "Supresores - Instalación", "Trabajo Eléctrico", "Otro" });
            cbTipoTrabajo.Location = new Point(189, 316);
            cbTipoTrabajo.Name = "cbTipoTrabajo";
            cbTipoTrabajo.Size = new Size(225, 23);
            cbTipoTrabajo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 316);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 44;
            label3.Text = "Tipo Trabajo";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(189, 27);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Ejemplo S.A";
            txtNombreCliente.Size = new Size(225, 23);
            txtNombreCliente.TabIndex = 42;
            // 
            // dtpOrdenCompra
            // 
            dtpOrdenCompra.Location = new Point(189, 171);
            dtpOrdenCompra.Name = "dtpOrdenCompra";
            dtpOrdenCompra.Size = new Size(225, 23);
            dtpOrdenCompra.TabIndex = 38;
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(189, 534);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(225, 23);
            cbVendedores.TabIndex = 37;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            cbEstado.Location = new Point(189, 563);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(225, 23);
            cbEstado.TabIndex = 36;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(189, 287);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 35;
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(255, 613);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(124, 613);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 563);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(189, 424);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Canton, Distrito, Direcciones";
            txtUbicacion.Size = new Size(225, 75);
            txtUbicacion.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 424);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 22;
            label14.Text = "Ubicación";
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(12, 505);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(64, 15);
            lblTarea.TabIndex = 20;
            lblTarea.Text = "Tarea Bitrix";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(12, 287);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(111, 15);
            lblPorcentaje.TabIndex = 14;
            lblPorcentaje.Text = "Porcentaje Anticipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(16, 229);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 12;
            lblMonto.Text = "Monto";
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(16, 113);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(77, 15);
            lblOferta.TabIndex = 10;
            lblOferta.Text = "Oferta Mecsa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 171);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 2;
            label5.Text = "Fecha Orden Compra";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(16, 32);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(73, 15);
            lblRazon.TabIndex = 1;
            lblRazon.Text = "Razon Social";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(12, 534);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 0;
            lblVendedor.Text = "Vendedor";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ofertasToolStripMenuItem, cotizacionesToolStripMenuItem, resumenToolStripMenuItem, informesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1365, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarToolStripMenuItem, toolStripSeparator1, usuariosToolStripMenuItem, configuraciónToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem });
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(173, 22);
            exportarToolStripMenuItem.Text = "Exportar Proyectos";
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
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem, agregarToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(173, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(116, 22);
            listaToolStripMenuItem.Text = "Lista ";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(116, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(173, 22);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.Click += configuraciónToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(170, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(173, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ofertasToolStripMenuItem
            // 
            ofertasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarOfertasToolStripMenuItem, agregarOfertaToolStripMenuItem });
            ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            ofertasToolStripMenuItem.Size = new Size(57, 20);
            ofertasToolStripMenuItem.Text = "Ofertas";
            // 
            // listarOfertasToolStripMenuItem
            // 
            listarOfertasToolStripMenuItem.Name = "listarOfertasToolStripMenuItem";
            listarOfertasToolStripMenuItem.Size = new Size(152, 22);
            listarOfertasToolStripMenuItem.Text = "Listar Ofertas";
            listarOfertasToolStripMenuItem.Click += listarOfertasToolStripMenuItem_Click;
            // 
            // agregarOfertaToolStripMenuItem
            // 
            agregarOfertaToolStripMenuItem.Name = "agregarOfertaToolStripMenuItem";
            agregarOfertaToolStripMenuItem.Size = new Size(152, 22);
            agregarOfertaToolStripMenuItem.Text = "Agregar Oferta";
            agregarOfertaToolStripMenuItem.Click += agregarOfertaToolStripMenuItem_Click;
            // 
            // cotizacionesToolStripMenuItem
            // 
            cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            cotizacionesToolStripMenuItem.Size = new Size(86, 20);
            cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            cotizacionesToolStripMenuItem.Click += cotizacionesToolStripMenuItem_Click;
            // 
            // resumenToolStripMenuItem
            // 
            resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            resumenToolStripMenuItem.Size = new Size(68, 20);
            resumenToolStripMenuItem.Text = "Resumen";
            resumenToolStripMenuItem.Click += resumenToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeInformesToolStripMenuItem, informesPendientesToolStripMenuItem, crearInformeToolStripMenuItem });
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(66, 20);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // listaDeInformesToolStripMenuItem
            // 
            listaDeInformesToolStripMenuItem.Name = "listaDeInformesToolStripMenuItem";
            listaDeInformesToolStripMenuItem.Size = new Size(182, 22);
            listaDeInformesToolStripMenuItem.Text = "Lista de Informes";
            listaDeInformesToolStripMenuItem.Click += listaDeInformesToolStripMenuItem_Click;
            // 
            // informesPendientesToolStripMenuItem
            // 
            informesPendientesToolStripMenuItem.Name = "informesPendientesToolStripMenuItem";
            informesPendientesToolStripMenuItem.Size = new Size(182, 22);
            informesPendientesToolStripMenuItem.Text = "Informes Pendientes";
            informesPendientesToolStripMenuItem.Click += informesPendientesToolStripMenuItem_Click;
            // 
            // crearInformeToolStripMenuItem
            // 
            crearInformeToolStripMenuItem.Name = "crearInformeToolStripMenuItem";
            crearInformeToolStripMenuItem.Size = new Size(182, 22);
            crearInformeToolStripMenuItem.Text = "Crear Informe";
            crearInformeToolStripMenuItem.Click += crearInformeToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.AutoClose = false;
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(61, 4);
            // 
            // numericUpDownTarea
            // 
            numericUpDownTarea.Location = new Point(189, 505);
            numericUpDownTarea.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownTarea.Name = "numericUpDownTarea";
            numericUpDownTarea.Size = new Size(225, 23);
            numericUpDownTarea.TabIndex = 62;
            numericUpDownTarea.ThousandsSeparator = true;
            // 
            // numericUpDownOferta
            // 
            numericUpDownOferta.Location = new Point(189, 113);
            numericUpDownOferta.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownOferta.Name = "numericUpDownOferta";
            numericUpDownOferta.Size = new Size(225, 23);
            numericUpDownOferta.TabIndex = 63;
            numericUpDownOferta.ThousandsSeparator = true;
            // 
            // ModuloAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1365, 738);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ModuloAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo Administrador";
            Load += ModuloAdministrador_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMontoIVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOferta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dgvProyectos;
        private GroupBox groupBox1;
        private DateTimePicker dtpOrdenCompra;
        private ComboBox cbVendedores;
        private ComboBox cbEstado;
        private NumericUpDown numericUpDownPorcentaje;
        private Button btnAgregar;
        private Button button2;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem ofertasToolStripMenuItem;
        private ToolStripMenuItem listarOfertasToolStripMenuItem;
        private ToolStripMenuItem agregarOfertaToolStripMenuItem;
        private ToolStripDropDownMenu agregarUsuarioToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtNombreCliente;
        private Button btnLimpiarBusqueda;
        private Button btnBuscar;
        private TextBox txtNumeroProyectoBuscar;
        private Label label2;
        private TextBox txtNombreBuscar;
        private ComboBox cbTipoTrabajo;
        private Label label3;
        private ComboBox cbProvincia;
        private Label label4;
        private ToolStripMenuItem cotizacionesToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem listaDeInformesToolStripMenuItem;
        private ToolStripMenuItem informesPendientesToolStripMenuItem;
        private ToolStripMenuItem crearInformeToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem resumenToolStripMenuItem;
        private TextBox txtCedula;
        private Label label6;
        private CheckBox checkBoxPublico;
        private Label label7;
        private TextBox txtOrdenCompra;
        private Label label8;
        private Label label10;
        private ComboBox comboBoxTipoMoneda;
        private Label label9;
        private Label label11;
        private TextBox txtDescripcion;
        private NumericUpDown numericUpDownMontoIVA;
        private NumericUpDown numericUpDownMonto;
        private NumericUpDown numericUpDownOferta;
        private NumericUpDown numericUpDownTarea;
    }
}