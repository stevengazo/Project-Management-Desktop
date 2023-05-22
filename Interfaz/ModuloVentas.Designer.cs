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
			comboBoxOfertas = new ComboBox();
			txtRazonSocial = new TextBox();
			dtpFechaOC = new DateTimePicker();
			cbVendedores = new ComboBox();
			comboBoxEstado = new ComboBox();
			numericUpDownPorcentaje = new NumericUpDown();
			dateTimePickerFinal = new DateTimePicker();
			dateTimePickerInicio = new DateTimePicker();
			btnAgregar = new Button();
			btnLimpiar = new Button();
			label17 = new Label();
			label16 = new Label();
			label15 = new Label();
			textBoxUbicacion = new TextBox();
			label14 = new Label();
			txtTareaBitrix = new TextBox();
			label13 = new Label();
			txtNumeroFacturaAnticipo = new TextBox();
			label11 = new Label();
			txtMonto = new TextBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			txtContacto = new TextBox();
			label7 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			groupBox2 = new GroupBox();
			limpar = new Button();
			btnBuscar = new Button();
			txtNumeroPBuscar = new TextBox();
			label2 = new Label();
			txtClienteBuscar = new TextBox();
			label1 = new Label();
			dgvProyectos = new DataGridView();
			saveFileDialog = new SaveFileDialog();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
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
			groupBox1.Controls.Add(comboBoxOfertas);
			groupBox1.Controls.Add(txtRazonSocial);
			groupBox1.Controls.Add(dtpFechaOC);
			groupBox1.Controls.Add(cbVendedores);
			groupBox1.Controls.Add(comboBoxEstado);
			groupBox1.Controls.Add(numericUpDownPorcentaje);
			groupBox1.Controls.Add(dateTimePickerFinal);
			groupBox1.Controls.Add(dateTimePickerInicio);
			groupBox1.Controls.Add(btnAgregar);
			groupBox1.Controls.Add(btnLimpiar);
			groupBox1.Controls.Add(label17);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(textBoxUbicacion);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(txtTareaBitrix);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(txtNumeroFacturaAnticipo);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(txtMonto);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(txtContacto);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new Point(12, 27);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(429, 607);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Agregar Proyecto";
			// 
			// comboBoxOfertas
			// 
			comboBoxOfertas.FormattingEnabled = true;
			comboBoxOfertas.Location = new Point(198, 152);
			comboBoxOfertas.Name = "comboBoxOfertas";
			comboBoxOfertas.Size = new Size(225, 23);
			comboBoxOfertas.TabIndex = 41;
			// 
			// txtRazonSocial
			// 
			txtRazonSocial.Location = new Point(198, 59);
			txtRazonSocial.Name = "txtRazonSocial";
			txtRazonSocial.PlaceholderText = "Ejemplo S.A";
			txtRazonSocial.Size = new Size(225, 23);
			txtRazonSocial.TabIndex = 6;
			// 
			// dtpFechaOC
			// 
			dtpFechaOC.Location = new Point(198, 91);
			dtpFechaOC.Name = "dtpFechaOC";
			dtpFechaOC.Size = new Size(225, 23);
			dtpFechaOC.TabIndex = 38;
			// 
			// cbVendedores
			// 
			cbVendedores.FormattingEnabled = true;
			cbVendedores.Location = new Point(198, 22);
			cbVendedores.Name = "cbVendedores";
			cbVendedores.Size = new Size(225, 23);
			cbVendedores.TabIndex = 37;
			// 
			// comboBoxEstado
			// 
			comboBoxEstado.FormattingEnabled = true;
			comboBoxEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
			comboBoxEstado.Location = new Point(198, 433);
			comboBoxEstado.Name = "comboBoxEstado";
			comboBoxEstado.Size = new Size(225, 23);
			comboBoxEstado.TabIndex = 36;
			comboBoxEstado.Text = "Pendiente de Ejecución";
			// 
			// numericUpDownPorcentaje
			// 
			numericUpDownPorcentaje.Location = new Point(198, 210);
			numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
			numericUpDownPorcentaje.Size = new Size(225, 23);
			numericUpDownPorcentaje.TabIndex = 35;
			// 
			// dateTimePickerFinal
			// 
			dateTimePickerFinal.Location = new Point(198, 404);
			dateTimePickerFinal.Name = "dateTimePickerFinal";
			dateTimePickerFinal.Size = new Size(225, 23);
			dateTimePickerFinal.TabIndex = 34;
			// 
			// dateTimePickerInicio
			// 
			dateTimePickerInicio.Location = new Point(198, 375);
			dateTimePickerInicio.Name = "dateTimePickerInicio";
			dateTimePickerInicio.Size = new Size(225, 23);
			dateTimePickerInicio.TabIndex = 33;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(300, 468);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(75, 23);
			btnAgregar.TabIndex = 31;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Location = new Point(198, 468);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(75, 23);
			btnLimpiar.TabIndex = 30;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click_1;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(24, 433);
			label17.Name = "label17";
			label17.Size = new Size(42, 15);
			label17.TabIndex = 28;
			label17.Text = "Estado";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(24, 404);
			label16.Name = "label16";
			label16.Size = new Size(103, 15);
			label16.TabIndex = 26;
			label16.Text = "Fecha Finalización";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(24, 375);
			label15.Name = "label15";
			label15.Size = new Size(70, 15);
			label15.TabIndex = 24;
			label15.Text = "Fecha Inicio";
			// 
			// textBoxUbicacion
			// 
			textBoxUbicacion.Location = new Point(198, 294);
			textBoxUbicacion.Multiline = true;
			textBoxUbicacion.Name = "textBoxUbicacion";
			textBoxUbicacion.PlaceholderText = "Provincia, Canton, Distrito, Indicaciones";
			textBoxUbicacion.Size = new Size(225, 75);
			textBoxUbicacion.TabIndex = 23;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(24, 297);
			label14.Name = "label14";
			label14.Size = new Size(60, 15);
			label14.TabIndex = 22;
			label14.Text = "Ubicación";
			// 
			// txtTareaBitrix
			// 
			txtTareaBitrix.Location = new Point(198, 265);
			txtTareaBitrix.Name = "txtTareaBitrix";
			txtTareaBitrix.PlaceholderText = "2155465";
			txtTareaBitrix.Size = new Size(225, 23);
			txtTareaBitrix.TabIndex = 21;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(24, 268);
			label13.Name = "label13";
			label13.Size = new Size(64, 15);
			label13.TabIndex = 20;
			label13.Text = "Tarea Bitrix";
			// 
			// txtNumeroFacturaAnticipo
			// 
			txtNumeroFacturaAnticipo.Location = new Point(198, 236);
			txtNumeroFacturaAnticipo.Name = "txtNumeroFacturaAnticipo";
			txtNumeroFacturaAnticipo.PlaceholderText = "136548";
			txtNumeroFacturaAnticipo.Size = new Size(225, 23);
			txtNumeroFacturaAnticipo.TabIndex = 17;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(24, 239);
			label11.Name = "label11";
			label11.Size = new Size(141, 15);
			label11.TabIndex = 16;
			label11.Text = "Número Factura Anticipo";
			// 
			// txtMonto
			// 
			txtMonto.Location = new Point(198, 181);
			txtMonto.Name = "txtMonto";
			txtMonto.PlaceholderText = "150000";
			txtMonto.Size = new Size(225, 23);
			txtMonto.TabIndex = 15;
			txtMonto.Leave += txtMonto_Leave;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(24, 210);
			label10.Name = "label10";
			label10.Size = new Size(111, 15);
			label10.TabIndex = 14;
			label10.Text = "Porcentaje Anticipo";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(24, 181);
			label9.Name = "label9";
			label9.Size = new Size(43, 15);
			label9.TabIndex = 12;
			label9.Text = "Monto";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(24, 152);
			label8.Name = "label8";
			label8.Size = new Size(77, 15);
			label8.TabIndex = 10;
			label8.Text = "Oferta Mecsa";
			// 
			// txtContacto
			// 
			txtContacto.Location = new Point(198, 120);
			txtContacto.Name = "txtContacto";
			txtContacto.PlaceholderText = "Pepe";
			txtContacto.Size = new Size(225, 23);
			txtContacto.TabIndex = 9;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(24, 123);
			label7.Name = "label7";
			label7.Size = new Size(56, 15);
			label7.TabIndex = 8;
			label7.Text = "Contacto";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(24, 94);
			label5.Name = "label5";
			label5.Size = new Size(120, 15);
			label5.TabIndex = 2;
			label5.Text = "Fecha Orden Compra";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(24, 62);
			label4.Name = "label4";
			label4.Size = new Size(73, 15);
			label4.TabIndex = 1;
			label4.Text = "Razon Social";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(24, 30);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 0;
			label3.Text = "Vendedor";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(limpar);
			groupBox2.Controls.Add(btnBuscar);
			groupBox2.Controls.Add(txtNumeroPBuscar);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(txtClienteBuscar);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(dgvProyectos);
			groupBox2.Location = new Point(447, 27);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(877, 607);
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
			dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProyectos.Location = new Point(6, 61);
			dgvProyectos.Name = "dgvProyectos";
			dgvProyectos.ReadOnly = true;
			dgvProyectos.RowTemplate.Height = 25;
			dgvProyectos.Size = new Size(865, 540);
			dgvProyectos.TabIndex = 0;
			dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
			// 
			// ModuloVentas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightBlue;
			ClientSize = new Size(1336, 646);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "ModuloVentas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modulo Ventas ";
			Load += Form1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
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