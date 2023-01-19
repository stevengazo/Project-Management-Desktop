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
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtNumeroProyecto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.cbVendedores = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProyectos = new System.Windows.Forms.DataGridView();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
			this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.agregarCotizaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.agregarCotizaciónToolStripMenuItem.Text = "Agregar Cotización";
			this.agregarCotizaciónToolStripMenuItem.Click += new System.EventHandler(this.agregarCotizaciónToolStripMenuItem_Click);
			// 
			// verCotizacionesToolStripMenuItem
			// 
			this.verCotizacionesToolStripMenuItem.Name = "verCotizacionesToolStripMenuItem";
			this.verCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.verCotizacionesToolStripMenuItem.Text = "Ver Cotizaciones";
			this.verCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.verCotizacionesToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRazonSocial);
			this.groupBox1.Controls.Add(this.txtNumeroProyecto);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.cbVendedores);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.textBox14);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.textBox13);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.textBox11);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.textBox10);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox7);
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
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(181, 98);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(225, 23);
			this.txtRazonSocial.TabIndex = 6;
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
			// dateTimePicker3
			// 
			this.dateTimePicker3.Location = new System.Drawing.Point(181, 130);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(225, 23);
			this.dateTimePicker3.TabIndex = 38;
			// 
			// cbVendedores
			// 
			this.cbVendedores.FormattingEnabled = true;
			this.cbVendedores.Location = new System.Drawing.Point(181, 61);
			this.cbVendedores.Name = "cbVendedores";
			this.cbVendedores.Size = new System.Drawing.Size(225, 23);
			this.cbVendedores.TabIndex = 37;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Pendiente de Ejecución",
            "En ejecución",
            "Finalizado con cobro",
            "Finalizado sin cobro"});
			this.comboBox2.Location = new System.Drawing.Point(181, 472);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(225, 23);
			this.comboBox2.TabIndex = 36;
			this.comboBox2.Text = "Pendiente de Ejecución";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(181, 249);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(225, 23);
			this.numericUpDown1.TabIndex = 35;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(181, 443);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(225, 23);
			this.dateTimePicker2.TabIndex = 34;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(181, 414);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
			this.dateTimePicker1.TabIndex = 33;
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
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(181, 333);
			this.textBox14.Multiline = true;
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(225, 75);
			this.textBox14.TabIndex = 23;
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
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(181, 304);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(225, 23);
			this.textBox13.TabIndex = 21;
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
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(181, 275);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(225, 23);
			this.textBox11.TabIndex = 17;
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
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(181, 220);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(225, 23);
			this.textBox10.TabIndex = 15;
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
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(181, 188);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(225, 23);
			this.textBox8.TabIndex = 11;
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
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(181, 159);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(225, 23);
			this.textBox7.TabIndex = 9;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dgvProyectos);
			this.groupBox2.Location = new System.Drawing.Point(447, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(967, 607);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Proyectos";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(473, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(365, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(102, 23);
			this.textBox2.TabIndex = 4;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(163, 23);
			this.textBox1.TabIndex = 2;
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
			this.Name = "ModuloVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modulo Ventas ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
		private Button button2;
		private Label label17;
		private Label label16;
		private Label label15;
		private TextBox textBox14;
		private Label label14;
		private TextBox textBox13;
		private Label label13;
		private TextBox textBox11;
		private Label label11;
		private TextBox textBox10;
		private Label label10;
		private Label label9;
		private TextBox textBox8;
		private Label label8;
		private TextBox textBox7;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label3;
		private GroupBox groupBox2;
		private Button button1;
		private TextBox textBox2;
		private Label label2;
		private Label label1;
		private DataGridView dgvProyectos;
		private ComboBox comboBox2;
		private NumericUpDown numericUpDown1;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
		private SaveFileDialog saveFileDialog;
		private DateTimePicker dateTimePicker3;
		private TextBox txtNumeroProyecto;
		private Label label6;
		private ToolStripMenuItem ofertasToolStripMenuItem;
		private ToolStripMenuItem agregarCotizaciónToolStripMenuItem;
		private ToolStripMenuItem verCotizacionesToolStripMenuItem;
		private TextBox txtRazonSocial;
		private ComboBox cbVendedores;
		private TextBox textBox1;
	}
}