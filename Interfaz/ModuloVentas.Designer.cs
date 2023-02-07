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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarCotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxOfertas = new System.Windows.Forms.ComboBox();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.dtpFechaOC = new System.Windows.Forms.DateTimePicker();
			this.cbVendedores = new System.Windows.Forms.ComboBox();
			this.comboBoxEstado = new System.Windows.Forms.ComboBox();
			this.numericUpDownPorcentaje = new System.Windows.Forms.NumericUpDown();
			this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxUbicacion = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTareaBitrix = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNumeroFacturaAnticipo = new System.Windows.Forms.TextBox();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.limpar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNumeroPBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClienteBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProyectos = new System.Windows.Forms.DataGridView();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ofertasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1426, 24);
			this.menuStrip1.TabIndex = 0;
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
            this.agregarCotizaciónToolStripMenuItem,
            this.verCotizacionesToolStripMenuItem});
			this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
			this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.ofertasToolStripMenuItem.Text = "Ofertas ";
			// 
			// agregarCotizaciónToolStripMenuItem
			// 
			this.agregarCotizaciónToolStripMenuItem.Name = "agregarCotizaciónToolStripMenuItem";
			this.agregarCotizaciónToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.agregarCotizaciónToolStripMenuItem.Text = "Agregar Cotización";
			this.agregarCotizaciónToolStripMenuItem.Click += new System.EventHandler(this.agregarCotizaciónToolStripMenuItem_Click);
			// 
			// verCotizacionesToolStripMenuItem
			// 
			this.verCotizacionesToolStripMenuItem.Name = "verCotizacionesToolStripMenuItem";
			this.verCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.verCotizacionesToolStripMenuItem.Text = "Ver Cotizaciones";
			this.verCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.verCotizacionesToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxOfertas);
			this.groupBox1.Controls.Add(this.txtRazonSocial);
			this.groupBox1.Controls.Add(this.dtpFechaOC);
			this.groupBox1.Controls.Add(this.cbVendedores);
			this.groupBox1.Controls.Add(this.comboBoxEstado);
			this.groupBox1.Controls.Add(this.numericUpDownPorcentaje);
			this.groupBox1.Controls.Add(this.dateTimePickerFinal);
			this.groupBox1.Controls.Add(this.dateTimePickerInicio);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.textBoxUbicacion);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtTareaBitrix);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtNumeroFacturaAnticipo);
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
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agregar Proyecto";
			// 
			// comboBoxOfertas
			// 
			this.comboBoxOfertas.FormattingEnabled = true;
			this.comboBoxOfertas.Location = new System.Drawing.Point(198, 152);
			this.comboBoxOfertas.Name = "comboBoxOfertas";
			this.comboBoxOfertas.Size = new System.Drawing.Size(225, 23);
			this.comboBoxOfertas.TabIndex = 41;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(198, 59);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.PlaceholderText = "Ejemplo S.A";
			this.txtRazonSocial.Size = new System.Drawing.Size(225, 23);
			this.txtRazonSocial.TabIndex = 6;
			// 
			// dtpFechaOC
			// 
			this.dtpFechaOC.Location = new System.Drawing.Point(198, 91);
			this.dtpFechaOC.Name = "dtpFechaOC";
			this.dtpFechaOC.Size = new System.Drawing.Size(225, 23);
			this.dtpFechaOC.TabIndex = 38;
			// 
			// cbVendedores
			// 
			this.cbVendedores.FormattingEnabled = true;
			this.cbVendedores.Location = new System.Drawing.Point(198, 22);
			this.cbVendedores.Name = "cbVendedores";
			this.cbVendedores.Size = new System.Drawing.Size(225, 23);
			this.cbVendedores.TabIndex = 37;
			// 
			// comboBoxEstado
			// 
			this.comboBoxEstado.FormattingEnabled = true;
			this.comboBoxEstado.Items.AddRange(new object[] {
            "Pendiente de Ejecución",
            "En ejecución",
            "Finalizado con cobro",
            "Finalizado sin cobro"});
			this.comboBoxEstado.Location = new System.Drawing.Point(198, 433);
			this.comboBoxEstado.Name = "comboBoxEstado";
			this.comboBoxEstado.Size = new System.Drawing.Size(225, 23);
			this.comboBoxEstado.TabIndex = 36;
			this.comboBoxEstado.Text = "Pendiente de Ejecución";
			// 
			// numericUpDownPorcentaje
			// 
			this.numericUpDownPorcentaje.Location = new System.Drawing.Point(198, 210);
			this.numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
			this.numericUpDownPorcentaje.Size = new System.Drawing.Size(225, 23);
			this.numericUpDownPorcentaje.TabIndex = 35;
			// 
			// dateTimePickerFinal
			// 
			this.dateTimePickerFinal.Location = new System.Drawing.Point(198, 404);
			this.dateTimePickerFinal.Name = "dateTimePickerFinal";
			this.dateTimePickerFinal.Size = new System.Drawing.Size(225, 23);
			this.dateTimePickerFinal.TabIndex = 34;
			// 
			// dateTimePickerInicio
			// 
			this.dateTimePickerInicio.Location = new System.Drawing.Point(198, 375);
			this.dateTimePickerInicio.Name = "dateTimePickerInicio";
			this.dateTimePickerInicio.Size = new System.Drawing.Size(225, 23);
			this.dateTimePickerInicio.TabIndex = 33;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(300, 468);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 31;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(198, 468);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 30;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(24, 433);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(42, 15);
			this.label17.TabIndex = 28;
			this.label17.Text = "Estado";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(24, 404);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(103, 15);
			this.label16.TabIndex = 26;
			this.label16.Text = "Fecha Finalización";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(24, 375);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 15);
			this.label15.TabIndex = 24;
			this.label15.Text = "Fecha Inicio";
			// 
			// textBoxUbicacion
			// 
			this.textBoxUbicacion.Location = new System.Drawing.Point(198, 294);
			this.textBoxUbicacion.Multiline = true;
			this.textBoxUbicacion.Name = "textBoxUbicacion";
			this.textBoxUbicacion.PlaceholderText = "Provincia, Canton, Distrito, Indicaciones";
			this.textBoxUbicacion.Size = new System.Drawing.Size(225, 75);
			this.textBoxUbicacion.TabIndex = 23;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(24, 297);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 15);
			this.label14.TabIndex = 22;
			this.label14.Text = "Ubicación";
			// 
			// txtTareaBitrix
			// 
			this.txtTareaBitrix.Location = new System.Drawing.Point(198, 265);
			this.txtTareaBitrix.Name = "txtTareaBitrix";
			this.txtTareaBitrix.PlaceholderText = "2155465";
			this.txtTareaBitrix.Size = new System.Drawing.Size(225, 23);
			this.txtTareaBitrix.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(24, 268);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 15);
			this.label13.TabIndex = 20;
			this.label13.Text = "Tarea Bitrix";
			// 
			// txtNumeroFacturaAnticipo
			// 
			this.txtNumeroFacturaAnticipo.Location = new System.Drawing.Point(198, 236);
			this.txtNumeroFacturaAnticipo.Name = "txtNumeroFacturaAnticipo";
			this.txtNumeroFacturaAnticipo.PlaceholderText = "136548";
			this.txtNumeroFacturaAnticipo.Size = new System.Drawing.Size(225, 23);
			this.txtNumeroFacturaAnticipo.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(24, 239);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(141, 15);
			this.label11.TabIndex = 16;
			this.label11.Text = "Número Factura Anticipo";
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(198, 181);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.PlaceholderText = "150000";
			this.txtMonto.Size = new System.Drawing.Size(225, 23);
			this.txtMonto.TabIndex = 15;
			this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 210);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 15);
			this.label10.TabIndex = 14;
			this.label10.Text = "Porcentaje Anticipo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(24, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 15);
			this.label9.TabIndex = 12;
			this.label9.Text = "Monto";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 15);
			this.label8.TabIndex = 10;
			this.label8.Text = "Oferta Mecsa";
			// 
			// txtContacto
			// 
			this.txtContacto.Location = new System.Drawing.Point(198, 120);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.PlaceholderText = "Pepe";
			this.txtContacto.Size = new System.Drawing.Size(225, 23);
			this.txtContacto.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Contacto";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Fecha Orden Compra";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Razon Social";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Vendedor";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.limpar);
			this.groupBox2.Controls.Add(this.btnBuscar);
			this.groupBox2.Controls.Add(this.txtNumeroPBuscar);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtClienteBuscar);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dgvProyectos);
			this.groupBox2.Location = new System.Drawing.Point(447, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(967, 607);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Proyectos";
			// 
			// limpar
			// 
			this.limpar.Location = new System.Drawing.Point(620, 29);
			this.limpar.Name = "limpar";
			this.limpar.Size = new System.Drawing.Size(141, 23);
			this.limpar.TabIndex = 6;
			this.limpar.Text = "Limpiar ";
			this.limpar.UseVisualStyleBackColor = true;
			this.limpar.Click += new System.EventHandler(this.limpar_Click);
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
			// txtNumeroPBuscar
			// 
			this.txtNumeroPBuscar.Location = new System.Drawing.Point(365, 29);
			this.txtNumeroPBuscar.Name = "txtNumeroPBuscar";
			this.txtNumeroPBuscar.Size = new System.Drawing.Size(102, 23);
			this.txtNumeroPBuscar.TabIndex = 4;
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
			// txtClienteBuscar
			// 
			this.txtClienteBuscar.Location = new System.Drawing.Point(56, 29);
			this.txtClienteBuscar.Name = "txtClienteBuscar";
			this.txtClienteBuscar.Size = new System.Drawing.Size(163, 23);
			this.txtClienteBuscar.TabIndex = 2;
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
			// ModuloVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1426, 646);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "ModuloVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modulo Ventas ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private Label label17;
		private Label label16;
		private Label label15;
		private TextBox textBoxUbicacion;
		private Label label14;
		private TextBox txtTareaBitrix;
		private Label label13;
		private TextBox txtNumeroFacturaAnticipo;
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
		private GroupBox groupBox2;
		private Button btnBuscar;
		private TextBox txtNumeroPBuscar;
		private Label label2;
		private Label label1;
		private DataGridView dgvProyectos;
		private ComboBox comboBoxEstado;
		private NumericUpDown numericUpDownPorcentaje;
		private DateTimePicker dateTimePickerFinal;
		private DateTimePicker dateTimePickerInicio;
		private SaveFileDialog saveFileDialog;
		private DateTimePicker dtpFechaOC;
		private ToolStripMenuItem ofertasToolStripMenuItem;
		private ToolStripMenuItem agregarCotizaciónToolStripMenuItem;
		private ToolStripMenuItem verCotizacionesToolStripMenuItem;
		private TextBox txtRazonSocial;
		private ComboBox cbVendedores;
		private TextBox txtClienteBuscar;
		private ComboBox comboBoxOfertas;
		private Button limpar;
	}
}