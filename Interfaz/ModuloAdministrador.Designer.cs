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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNumeroProyectoBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombreBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProyectos = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.cbOfertas = new System.Windows.Forms.ComboBox();
			this.txtNumeroProyecto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpOrdenCompra = new System.Windows.Forms.DateTimePicker();
			this.cbVendedores = new System.Windows.Forms.ComboBox();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.numericUpDownPorcentaje = new System.Windows.Forms.NumericUpDown();
			this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtUbicacion = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtNumeroTarea = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNumeroFactura = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtContacto = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listarOfertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarOfertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnLimpiarBusqueda);
			this.groupBox2.Controls.Add(this.btnBuscar);
			this.groupBox2.Controls.Add(this.txtNumeroProyectoBuscar);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtNombreBuscar);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dgvProyectos);
			this.groupBox2.Location = new System.Drawing.Point(447, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(967, 607);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Proyectos";
			// 
			// btnLimpiarBusqueda
			// 
			this.btnLimpiarBusqueda.Location = new System.Drawing.Point(620, 28);
			this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
			this.btnLimpiarBusqueda.Size = new System.Drawing.Size(141, 23);
			this.btnLimpiarBusqueda.TabIndex = 6;
			this.btnLimpiarBusqueda.Text = "Limpiar";
			this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
			this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(473, 28);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(141, 23);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtNumeroProyectoBuscar
			// 
			this.txtNumeroProyectoBuscar.Location = new System.Drawing.Point(365, 29);
			this.txtNumeroProyectoBuscar.Name = "txtNumeroProyectoBuscar";
			this.txtNumeroProyectoBuscar.Size = new System.Drawing.Size(102, 23);
			this.txtNumeroProyectoBuscar.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Numero de Proyecto";
			// 
			// txtNombreBuscar
			// 
			this.txtNombreBuscar.Location = new System.Drawing.Point(56, 29);
			this.txtNombreBuscar.Name = "txtNombreBuscar";
			this.txtNombreBuscar.Size = new System.Drawing.Size(163, 23);
			this.txtNombreBuscar.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cliente";
			// 
			// dgvProyectos
			// 
			this.dgvProyectos.AllowUserToAddRows = false;
			this.dgvProyectos.AllowUserToDeleteRows = false;
			this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProyectos.Location = new System.Drawing.Point(6, 61);
			this.dgvProyectos.Name = "dgvProyectos";
			this.dgvProyectos.ReadOnly = true;
			this.dgvProyectos.RowTemplate.Height = 25;
			this.dgvProyectos.Size = new System.Drawing.Size(955, 540);
			this.dgvProyectos.TabIndex = 0;
			this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNombreCliente);
			this.groupBox1.Controls.Add(this.cbOfertas);
			this.groupBox1.Controls.Add(this.txtNumeroProyecto);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtpOrdenCompra);
			this.groupBox1.Controls.Add(this.cbVendedores);
			this.groupBox1.Controls.Add(this.cbEstado);
			this.groupBox1.Controls.Add(this.numericUpDownPorcentaje);
			this.groupBox1.Controls.Add(this.dtpFechaFinal);
			this.groupBox1.Controls.Add(this.dtpFechaInicio);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtUbicacion);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtNumeroTarea);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtNumeroFactura);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtMonto);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtContacto);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(429, 607);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agregar Proyecto";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(181, 98);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.PlaceholderText = "Ejemplo S.A";
			this.txtNombreCliente.Size = new System.Drawing.Size(225, 23);
			this.txtNombreCliente.TabIndex = 42;
			// 
			// cbOfertas
			// 
			this.cbOfertas.FormattingEnabled = true;
			this.cbOfertas.Location = new System.Drawing.Point(181, 191);
			this.cbOfertas.Name = "cbOfertas";
			this.cbOfertas.Size = new System.Drawing.Size(225, 23);
			this.cbOfertas.TabIndex = 41;
			// 
			// txtNumeroProyecto
			// 
			this.txtNumeroProyecto.Location = new System.Drawing.Point(181, 29);
			this.txtNumeroProyecto.Name = "txtNumeroProyecto";
			this.txtNumeroProyecto.ReadOnly = true;
			this.txtNumeroProyecto.Size = new System.Drawing.Size(225, 23);
			this.txtNumeroProyecto.TabIndex = 40;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 15);
			this.label6.TabIndex = 39;
			this.label6.Text = "Numero de Proyecto";
			// 
			// dtpOrdenCompra
			// 
			this.dtpOrdenCompra.Location = new System.Drawing.Point(181, 130);
			this.dtpOrdenCompra.Name = "dtpOrdenCompra";
			this.dtpOrdenCompra.Size = new System.Drawing.Size(225, 23);
			this.dtpOrdenCompra.TabIndex = 38;
			// 
			// cbVendedores
			// 
			this.cbVendedores.FormattingEnabled = true;
			this.cbVendedores.Location = new System.Drawing.Point(181, 61);
			this.cbVendedores.Name = "cbVendedores";
			this.cbVendedores.Size = new System.Drawing.Size(225, 23);
			this.cbVendedores.TabIndex = 37;
			// 
			// cbEstado
			// 
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            "Pendiente de Ejecución",
            "En ejecución",
            "Finalizado con cobro",
            "Finalizado sin cobro"});
			this.cbEstado.Location = new System.Drawing.Point(181, 472);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(225, 23);
			this.cbEstado.TabIndex = 36;
			this.cbEstado.Text = "Pendiente de Ejecución";
			// 
			// numericUpDownPorcentaje
			// 
			this.numericUpDownPorcentaje.Location = new System.Drawing.Point(181, 249);
			this.numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
			this.numericUpDownPorcentaje.Size = new System.Drawing.Size(225, 23);
			this.numericUpDownPorcentaje.TabIndex = 35;
			// 
			// dtpFechaFinal
			// 
			this.dtpFechaFinal.Location = new System.Drawing.Point(181, 443);
			this.dtpFechaFinal.Name = "dtpFechaFinal";
			this.dtpFechaFinal.Size = new System.Drawing.Size(225, 23);
			this.dtpFechaFinal.TabIndex = 34;
			// 
			// dtpFechaInicio
			// 
			this.dtpFechaInicio.Location = new System.Drawing.Point(181, 414);
			this.dtpFechaInicio.Name = "dtpFechaInicio";
			this.dtpFechaInicio.Size = new System.Drawing.Size(225, 23);
			this.dtpFechaInicio.TabIndex = 33;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(283, 507);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 31;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(181, 507);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 30;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(7, 472);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(42, 15);
			this.label17.TabIndex = 28;
			this.label17.Text = "Estado";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(7, 443);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(103, 15);
			this.label16.TabIndex = 26;
			this.label16.Text = "Fecha Finalización";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(7, 414);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 15);
			this.label15.TabIndex = 24;
			this.label15.Text = "Fecha Inicio";
			// 
			// txtUbicacion
			// 
			this.txtUbicacion.Location = new System.Drawing.Point(181, 333);
			this.txtUbicacion.Multiline = true;
			this.txtUbicacion.Name = "txtUbicacion";
			this.txtUbicacion.PlaceholderText = "Provincia, Canton, Distrito, Direcciones";
			this.txtUbicacion.Size = new System.Drawing.Size(225, 75);
			this.txtUbicacion.TabIndex = 23;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(7, 336);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 15);
			this.label14.TabIndex = 22;
			this.label14.Text = "Ubicación";
			// 
			// txtNumeroTarea
			// 
			this.txtNumeroTarea.Location = new System.Drawing.Point(181, 304);
			this.txtNumeroTarea.Name = "txtNumeroTarea";
			this.txtNumeroTarea.PlaceholderText = "4582";
			this.txtNumeroTarea.Size = new System.Drawing.Size(225, 23);
			this.txtNumeroTarea.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 307);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 15);
			this.label13.TabIndex = 20;
			this.label13.Text = "Tarea Bitrix";
			// 
			// txtNumeroFactura
			// 
			this.txtNumeroFactura.Location = new System.Drawing.Point(181, 275);
			this.txtNumeroFactura.Name = "txtNumeroFactura";
			this.txtNumeroFactura.PlaceholderText = "15632";
			this.txtNumeroFactura.Size = new System.Drawing.Size(225, 23);
			this.txtNumeroFactura.TabIndex = 17;
			this.txtNumeroFactura.Text = "12588";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 278);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(93, 15);
			this.label11.TabIndex = 16;
			this.label11.Text = "Número Factura";
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(181, 220);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.PlaceholderText = "125000";
			this.txtMonto.Size = new System.Drawing.Size(225, 23);
			this.txtMonto.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 249);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 15);
			this.label10.TabIndex = 14;
			this.label10.Text = "Porcentaje Anticipo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 220);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 15);
			this.label9.TabIndex = 12;
			this.label9.Text = "Monto";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 191);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 15);
			this.label8.TabIndex = 10;
			this.label8.Text = "Oferta Mecsa";
			// 
			// txtContacto
			// 
			this.txtContacto.Location = new System.Drawing.Point(181, 159);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.PlaceholderText = "Pepe";
			this.txtContacto.Size = new System.Drawing.Size(225, 23);
			this.txtContacto.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Contacto";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Fecha Orden Compra";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Razon Social";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Vendedor";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1420, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
			// 
			// exportarToolStripMenuItem
			// 
			this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
			this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
			this.exportarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.exportarToolStripMenuItem.Text = "Exportar";
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.excelToolStripMenuItem.Text = "Excel";
			this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// ofertasToolStripMenuItem
			// 
			this.ofertasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarOfertasToolStripMenuItem,
            this.agregarOfertaToolStripMenuItem});
			this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
			this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.ofertasToolStripMenuItem.Text = "Ofertas";
			// 
			// listarOfertasToolStripMenuItem
			// 
			this.listarOfertasToolStripMenuItem.Name = "listarOfertasToolStripMenuItem";
			this.listarOfertasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.listarOfertasToolStripMenuItem.Text = "Listar Ofertas";
			this.listarOfertasToolStripMenuItem.Click += new System.EventHandler(this.listarOfertasToolStripMenuItem_Click);
			// 
			// agregarOfertaToolStripMenuItem
			// 
			this.agregarOfertaToolStripMenuItem.Name = "agregarOfertaToolStripMenuItem";
			this.agregarOfertaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.agregarOfertaToolStripMenuItem.Text = "Agregar Oferta";
			this.agregarOfertaToolStripMenuItem.Click += new System.EventHandler(this.agregarOfertaToolStripMenuItem_Click);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVendedoresToolStripMenuItem,
            this.agregarUsuarioToolStripMenuItem1});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			// 
			// listarVendedoresToolStripMenuItem
			// 
			this.listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
			this.listarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.listarVendedoresToolStripMenuItem.Text = "Listar Usuarios";
			this.listarVendedoresToolStripMenuItem.Click += new System.EventHandler(this.listarVendedoresToolStripMenuItem_Click);
			// 
			// agregarUsuarioToolStripMenuItem1
			// 
			this.agregarUsuarioToolStripMenuItem1.Name = "agregarUsuarioToolStripMenuItem1";
			this.agregarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
			this.agregarUsuarioToolStripMenuItem1.Text = "Agregar Usuario";
			this.agregarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem1_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
			// 
			// agregarUsuarioToolStripMenuItem
			// 
			this.agregarUsuarioToolStripMenuItem.AutoClose = false;
			this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
			this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
			// 
			// ModuloAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1420, 647);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "ModuloAdministrador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modulo Administrador";
			this.Load += new System.EventHandler(this.ModuloAdministrador_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox groupBox2;
		private Label label1;
		private DataGridView dgvProyectos;
		private GroupBox groupBox1;
		private TextBox txtNumeroProyecto;
		private Label label6;
		private DateTimePicker dtpOrdenCompra;
		private ComboBox cbVendedores;
		private ComboBox cbEstado;
		private NumericUpDown numericUpDownPorcentaje;
		private DateTimePicker dtpFechaFinal;
		private DateTimePicker dtpFechaInicio;
		private Button btnAgregar;
		private Button button2;
		private Label label17;
		private Label label16;
		private Label label15;
		private TextBox txtUbicacion;
		private Label label14;
		private TextBox txtNumeroTarea;
		private Label label13;
		private TextBox txtNumeroFactura;
		private Label label11;
		private TextBox txtMonto;
		private Label label10;
		private Label label9;
		private Label label8;
		private TextBox txtContacto;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label3;
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
		private ToolStripMenuItem usuariosToolStripMenuItem;
		private ToolStripMenuItem listarVendedoresToolStripMenuItem;
		private ToolStripMenuItem agregarUsuarioToolStripMenuItem1;
		private ToolStripDropDownMenu agregarUsuarioToolStripMenuItem;
		private SaveFileDialog saveFileDialog1;
		private ComboBox cbOfertas;
		private TextBox txtNombreCliente;
		private Button btnLimpiarBusqueda;
		private Button btnBuscar;
		private TextBox txtNumeroProyectoBuscar;
		private Label label2;
		private TextBox txtNombreBuscar;
	}
}