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
            txtCedula = new TextBox();
            label3 = new Label();
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
            lblEstado = new Label();
            lblFechaFinalizacion = new Label();
            lblFechaInicio = new Label();
            textBoxUbicacion = new TextBox();
            lblUbicacion = new Label();
            txtTareaBitrix = new TextBox();
            lblTarea = new Label();
            txtNumeroFacturaAnticipo = new TextBox();
            lblFacturaAnticipo = new Label();
            txtMonto = new TextBox();
            lblPorcentaje = new Label();
            lblMonto = new Label();
            lblOferta = new Label();
            txtContacto = new TextBox();
            lblContacto = new Label();
            lblFechaOC = new Label();
            lblRazon = new Label();
            lblVendedor = new Label();
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
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label3);
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
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(lblFechaFinalizacion);
            groupBox1.Controls.Add(lblFechaInicio);
            groupBox1.Controls.Add(textBoxUbicacion);
            groupBox1.Controls.Add(lblUbicacion);
            groupBox1.Controls.Add(txtTareaBitrix);
            groupBox1.Controls.Add(lblTarea);
            groupBox1.Controls.Add(txtNumeroFacturaAnticipo);
            groupBox1.Controls.Add(lblFacturaAnticipo);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(lblPorcentaje);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(lblOferta);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(lblContacto);
            groupBox1.Controls.Add(lblFechaOC);
            groupBox1.Controls.Add(lblRazon);
            groupBox1.Controls.Add(lblVendedor);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 607);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Proyecto";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(198, 88);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "1111111111111111";
            txtCedula.Size = new Size(225, 23);
            txtCedula.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 91);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 42;
            label3.Text = "Cedula";
            // 
            // comboBoxOfertas
            // 
            comboBoxOfertas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOfertas.FormattingEnabled = true;
            comboBoxOfertas.Location = new Point(198, 184);
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
            dtpFechaOC.Location = new Point(198, 123);
            dtpFechaOC.Name = "dtpFechaOC";
            dtpFechaOC.Size = new Size(225, 23);
            dtpFechaOC.TabIndex = 38;
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(198, 22);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(225, 23);
            cbVendedores.TabIndex = 37;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            comboBoxEstado.Location = new Point(198, 465);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(225, 23);
            comboBoxEstado.TabIndex = 36;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(198, 242);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 35;
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.Location = new Point(198, 436);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(225, 23);
            dateTimePickerFinal.TabIndex = 34;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(198, 407);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(225, 23);
            dateTimePickerInicio.TabIndex = 33;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(300, 500);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(198, 500);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 465);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado";
            // 
            // lblFechaFinalizacion
            // 
            lblFechaFinalizacion.AutoSize = true;
            lblFechaFinalizacion.Location = new Point(24, 436);
            lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            lblFechaFinalizacion.Size = new Size(103, 15);
            lblFechaFinalizacion.TabIndex = 26;
            lblFechaFinalizacion.Text = "Fecha Finalización";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(24, 407);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 24;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // textBoxUbicacion
            // 
            textBoxUbicacion.Location = new Point(198, 326);
            textBoxUbicacion.Multiline = true;
            textBoxUbicacion.Name = "textBoxUbicacion";
            textBoxUbicacion.PlaceholderText = "Provincia, Canton, Distrito, Indicaciones";
            textBoxUbicacion.Size = new Size(225, 75);
            textBoxUbicacion.TabIndex = 23;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(24, 329);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 22;
            lblUbicacion.Text = "Ubicación";
            // 
            // txtTareaBitrix
            // 
            txtTareaBitrix.Location = new Point(198, 297);
            txtTareaBitrix.Name = "txtTareaBitrix";
            txtTareaBitrix.PlaceholderText = "2155465";
            txtTareaBitrix.Size = new Size(225, 23);
            txtTareaBitrix.TabIndex = 21;
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(24, 300);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(64, 15);
            lblTarea.TabIndex = 20;
            lblTarea.Text = "Tarea Bitrix";
            // 
            // txtNumeroFacturaAnticipo
            // 
            txtNumeroFacturaAnticipo.Location = new Point(198, 268);
            txtNumeroFacturaAnticipo.Name = "txtNumeroFacturaAnticipo";
            txtNumeroFacturaAnticipo.PlaceholderText = "136548";
            txtNumeroFacturaAnticipo.Size = new Size(225, 23);
            txtNumeroFacturaAnticipo.TabIndex = 17;
            // 
            // lblFacturaAnticipo
            // 
            lblFacturaAnticipo.AutoSize = true;
            lblFacturaAnticipo.Location = new Point(24, 271);
            lblFacturaAnticipo.Name = "lblFacturaAnticipo";
            lblFacturaAnticipo.Size = new Size(141, 15);
            lblFacturaAnticipo.TabIndex = 16;
            lblFacturaAnticipo.Text = "Número Factura Anticipo";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(198, 213);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "150000";
            txtMonto.Size = new Size(225, 23);
            txtMonto.TabIndex = 15;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(24, 242);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(111, 15);
            lblPorcentaje.TabIndex = 14;
            lblPorcentaje.Text = "Porcentaje Anticipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(24, 213);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 12;
            lblMonto.Text = "Monto";
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(24, 184);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(77, 15);
            lblOferta.TabIndex = 10;
            lblOferta.Text = "Oferta Mecsa";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(198, 152);
            txtContacto.Name = "txtContacto";
            txtContacto.PlaceholderText = "Pepe";
            txtContacto.Size = new Size(225, 23);
            txtContacto.TabIndex = 9;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(24, 155);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 8;
            lblContacto.Text = "Contacto";
            // 
            // lblFechaOC
            // 
            lblFechaOC.AutoSize = true;
            lblFechaOC.Location = new Point(24, 126);
            lblFechaOC.Name = "lblFechaOC";
            lblFechaOC.Size = new Size(120, 15);
            lblFechaOC.TabIndex = 2;
            lblFechaOC.Text = "Fecha Orden Compra";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(24, 62);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(73, 15);
            lblRazon.TabIndex = 1;
            lblRazon.Text = "Razon Social";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(24, 30);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 0;
            lblVendedor.Text = "Vendedor";
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
            dgvProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1336, 646);
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
        private Label lblEstado;
        private Label lblFechaFinalizacion;
        private Label lblFechaInicio;
        private TextBox textBoxUbicacion;
        private Label lblUbicacion;
        private TextBox txtTareaBitrix;
        private Label lblTarea;
        private TextBox txtNumeroFacturaAnticipo;
        private Label lblFacturaAnticipo;
        private TextBox txtMonto;
        private Label lblPorcentaje;
        private Label lblMonto;
        private Label lblOferta;
        private TextBox txtContacto;
        private Label lblContacto;
        private Label lblFechaOC;
        private Label lblRazon;
        private Label lblVendedor;
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
        private TextBox txtCedula;
        private Label label3;
    }
}