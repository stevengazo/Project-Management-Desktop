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
            txtNombreCliente = new TextBox();
            cbOfertas = new ComboBox();
            dtpOrdenCompra = new DateTimePicker();
            cbVendedores = new ComboBox();
            cbEstado = new ComboBox();
            numericUpDownPorcentaje = new NumericUpDown();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            btnAgregar = new Button();
            button2 = new Button();
            lblEstado = new Label();
            label16 = new Label();
            label15 = new Label();
            txtUbicacion = new TextBox();
            label14 = new Label();
            txtNumeroTarea = new TextBox();
            lblTarea = new Label();
            txtNumeroFactura = new TextBox();
            lblFacturaAnticipo = new Label();
            txtMonto = new TextBox();
            lblPorcentaje = new Label();
            lblMonto = new Label();
            lblOferta = new Label();
            txtContacto = new TextBox();
            lblContacto = new Label();
            label5 = new Label();
            lblRazon = new Label();
            lblVendedor = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            listarOfertasToolStripMenuItem = new ToolStripMenuItem();
            agregarOfertaToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            listarVendedoresToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem1 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripDropDownMenu();
            saveFileDialog1 = new SaveFileDialog();
            txtTipoTrabajo = new TextBox();
            label3 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
            menuStrip1.SuspendLayout();
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
            groupBox2.Location = new Point(435, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 620);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proyectos";
            // 
            // btnLimpiarBusqueda
            // 
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
            dgvProyectos.Size = new Size(912, 552);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTipoTrabajo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(cbOfertas);
            groupBox1.Controls.Add(dtpOrdenCompra);
            groupBox1.Controls.Add(cbVendedores);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(numericUpDownPorcentaje);
            groupBox1.Controls.Add(dtpFechaFinal);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtNumeroTarea);
            groupBox1.Controls.Add(lblTarea);
            groupBox1.Controls.Add(txtNumeroFactura);
            groupBox1.Controls.Add(lblFacturaAnticipo);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(lblPorcentaje);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(lblOferta);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(lblContacto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblRazon);
            groupBox1.Controls.Add(lblVendedor);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 623);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Proyecto";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(189, 59);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Ejemplo S.A";
            txtNombreCliente.Size = new Size(225, 23);
            txtNombreCliente.TabIndex = 42;
            // 
            // cbOfertas
            // 
            cbOfertas.FormattingEnabled = true;
            cbOfertas.Location = new Point(189, 152);
            cbOfertas.Name = "cbOfertas";
            cbOfertas.Size = new Size(225, 23);
            cbOfertas.TabIndex = 41;
            // 
            // dtpOrdenCompra
            // 
            dtpOrdenCompra.Location = new Point(189, 91);
            dtpOrdenCompra.Name = "dtpOrdenCompra";
            dtpOrdenCompra.Size = new Size(225, 23);
            dtpOrdenCompra.TabIndex = 38;
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(189, 22);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(225, 23);
            cbVendedores.TabIndex = 37;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            cbEstado.Location = new Point(189, 410);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(225, 23);
            cbEstado.TabIndex = 36;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(189, 210);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 35;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(189, 381);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(225, 23);
            dtpFechaFinal.TabIndex = 34;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(189, 352);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(225, 23);
            dtpFechaInicio.TabIndex = 33;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(291, 445);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 445);
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
            lblEstado.Location = new Point(15, 410);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 381);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 26;
            label16.Text = "Fecha Finalización";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 352);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 24;
            label15.Text = "Fecha Inicio";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(189, 294);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Provincia, Canton, Distrito, Direcciones";
            txtUbicacion.Size = new Size(225, 23);
            txtUbicacion.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 297);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 22;
            label14.Text = "Ubicación";
            // 
            // txtNumeroTarea
            // 
            txtNumeroTarea.Location = new Point(189, 265);
            txtNumeroTarea.Name = "txtNumeroTarea";
            txtNumeroTarea.PlaceholderText = "4582";
            txtNumeroTarea.Size = new Size(225, 23);
            txtNumeroTarea.TabIndex = 21;
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(15, 268);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(64, 15);
            lblTarea.TabIndex = 20;
            lblTarea.Text = "Tarea Bitrix";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(189, 236);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.PlaceholderText = "15632";
            txtNumeroFactura.Size = new Size(225, 23);
            txtNumeroFactura.TabIndex = 17;
            // 
            // lblFacturaAnticipo
            // 
            lblFacturaAnticipo.AutoSize = true;
            lblFacturaAnticipo.Location = new Point(15, 239);
            lblFacturaAnticipo.Name = "lblFacturaAnticipo";
            lblFacturaAnticipo.Size = new Size(93, 15);
            lblFacturaAnticipo.TabIndex = 16;
            lblFacturaAnticipo.Text = "Número Factura";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(189, 181);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "125000";
            txtMonto.Size = new Size(225, 23);
            txtMonto.TabIndex = 15;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(15, 210);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(111, 15);
            lblPorcentaje.TabIndex = 14;
            lblPorcentaje.Text = "Porcentaje Anticipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(15, 181);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 12;
            lblMonto.Text = "Monto";
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(15, 152);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(77, 15);
            lblOferta.TabIndex = 10;
            lblOferta.Text = "Oferta Mecsa";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(189, 120);
            txtContacto.Name = "txtContacto";
            txtContacto.PlaceholderText = "Pepe";
            txtContacto.Size = new Size(225, 23);
            txtContacto.TabIndex = 9;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(15, 123);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 8;
            lblContacto.Text = "Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 94);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 2;
            label5.Text = "Fecha Orden Compra";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(15, 62);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(73, 15);
            lblRazon.TabIndex = 1;
            lblRazon.Text = "Razon Social";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(15, 30);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 0;
            lblVendedor.Text = "Vendedor";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ofertasToolStripMenuItem, usuariosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1365, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
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
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarVendedoresToolStripMenuItem, agregarUsuarioToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listarVendedoresToolStripMenuItem
            // 
            listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
            listarVendedoresToolStripMenuItem.Size = new Size(159, 22);
            listarVendedoresToolStripMenuItem.Text = "Listar Usuarios";
            listarVendedoresToolStripMenuItem.Click += listarVendedoresToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem1
            // 
            agregarUsuarioToolStripMenuItem1.Name = "agregarUsuarioToolStripMenuItem1";
            agregarUsuarioToolStripMenuItem1.Size = new Size(159, 22);
            agregarUsuarioToolStripMenuItem1.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem1.Click += agregarUsuarioToolStripMenuItem1_Click;
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
            // txtTipoTrabajo
            // 
            txtTipoTrabajo.Location = new Point(189, 323);
            txtTipoTrabajo.Multiline = true;
            txtTipoTrabajo.Name = "txtTipoTrabajo";
            txtTipoTrabajo.PlaceholderText = "Demarcación, Sellador, Asfaltado....";
            txtTipoTrabajo.Size = new Size(225, 23);
            txtTipoTrabajo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 326);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 44;
            label3.Text = "Tipo de Trabajo";
            // 
            // ModuloAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1365, 647);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicio;
        private Button btnAgregar;
        private Button button2;
        private Label lblEstado;
        private Label label16;
        private Label label15;
        private TextBox txtUbicacion;
        private Label label14;
        private TextBox txtNumeroTarea;
        private Label lblTarea;
        private TextBox txtNumeroFactura;
        private Label lblFacturaAnticipo;
        private TextBox txtMonto;
        private Label lblPorcentaje;
        private Label lblMonto;
        private Label lblOferta;
        private TextBox txtContacto;
        private Label lblContacto;
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
        private TextBox txtTipoTrabajo;
        private Label label3;
    }
}