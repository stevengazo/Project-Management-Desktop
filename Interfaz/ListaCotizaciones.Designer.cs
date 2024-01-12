namespace Interfaz
{
    partial class ListaCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCotizaciones));
            groupBox1 = new GroupBox();
            comboBoxCategoria = new ComboBox();
            label1 = new Label();
            txtDireccion = new TextBox();
            cbProvincia = new ComboBox();
            label19 = new Label();
            label17 = new Label();
            numTotal = new NumericUpDown();
            ckPuPri = new CheckBox();
            label16 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            label15 = new Label();
            numImprevisto = new NumericUpDown();
            label14 = new Label();
            numViaticos = new NumericUpDown();
            label13 = new Label();
            numProductos = new NumericUpDown();
            label12 = new Label();
            numMaterial = new NumericUpDown();
            label11 = new Label();
            numKilometraje = new NumericUpDown();
            label10 = new Label();
            numMO = new NumericUpDown();
            label9 = new Label();
            numDiasLaborales = new NumericUpDown();
            label8 = new Label();
            numTrabajadores = new NumericUpDown();
            label7 = new Label();
            cbOferta = new ComboBox();
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            txtCliente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            textBox1 = new TextBox();
            btnBuscarLimpiar = new Button();
            btnBuscar = new Button();
            label2 = new Label();
            txtBuscarCLiente = new TextBox();
            groupBox3 = new GroupBox();
            dataGridViewCotizaciones = new DataGridView();
            menuStrip1 = new MenuStrip();
            agToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numImprevisto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numViaticos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKilometraje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiasLaborales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTrabajadores).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCotizaciones).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(comboBoxCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(cbProvincia);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(numTotal);
            groupBox1.Controls.Add(ckPuPri);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(numImprevisto);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(numViaticos);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(numProductos);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(numMaterial);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(numKilometraje);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(numMO);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numDiasLaborales);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numTrabajadores);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbOferta);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 688);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.ForeColor = SystemColors.ActiveCaptionText;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "DDCE - Instalación", "DDCE - Mejoras", "DDCE - Mantenimiento", "Ionizante - Instalación", "Ionizante - Mejoras", "Ionizante - Mantenimiento", "Torre - Instalación ", "Torre - Mantenimiento", "Torre - Mejoras ", "Torre - Desinstalación", "Supresores - Instalación", "Malla - Instalación", "Trabajos Eléctricos", "Otros" });
            comboBoxCategoria.Location = new Point(140, 539);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(167, 23);
            comboBoxCategoria.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 542);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 35;
            label1.Text = "Tipo Cotización";
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = SystemColors.ActiveCaptionText;
            txtDireccion.Location = new Point(140, 196);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(167, 23);
            txtDireccion.TabIndex = 34;
            // 
            // cbProvincia
            // 
            cbProvincia.ForeColor = SystemColors.ActiveCaptionText;
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Alajuela", "Heredia", "Puntarenas", "Guanacaste", "Limón" });
            cbProvincia.Location = new Point(140, 164);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(167, 23);
            cbProvincia.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 167);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 32;
            label19.Text = "Provincia";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 483);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 31;
            label17.Text = "Total";
            // 
            // numTotal
            // 
            numTotal.DecimalPlaces = 2;
            numTotal.ForeColor = SystemColors.ActiveCaptionText;
            numTotal.Location = new Point(140, 481);
            numTotal.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numTotal.Name = "numTotal";
            numTotal.Size = new Size(167, 23);
            numTotal.TabIndex = 30;
            // 
            // ckPuPri
            // 
            ckPuPri.AutoSize = true;
            ckPuPri.ForeColor = SystemColors.ActiveCaptionText;
            ckPuPri.Location = new Point(140, 222);
            ckPuPri.Name = "ckPuPri";
            ckPuPri.Size = new Size(66, 19);
            ckPuPri.TabIndex = 29;
            ckPuPri.Text = "Privado";
            ckPuPri.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 226);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 28;
            label16.Text = "Tipo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.WindowText;
            btnLimpiar.Location = new Point(45, 596);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 23);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.WindowText;
            btnAgregar.Location = new Point(151, 596);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 454);
            label15.Name = "label15";
            label15.Size = new Size(102, 15);
            label15.TabIndex = 25;
            label15.Text = "Monto Imprevisto";
            // 
            // numImprevisto
            // 
            numImprevisto.DecimalPlaces = 2;
            numImprevisto.ForeColor = SystemColors.ActiveCaptionText;
            numImprevisto.Location = new Point(140, 452);
            numImprevisto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numImprevisto.Name = "numImprevisto";
            numImprevisto.Size = new Size(167, 23);
            numImprevisto.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 425);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 23;
            label14.Text = "Monto Viaticos";
            // 
            // numViaticos
            // 
            numViaticos.DecimalPlaces = 2;
            numViaticos.ForeColor = SystemColors.ActiveCaptionText;
            numViaticos.Location = new Point(140, 423);
            numViaticos.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numViaticos.Name = "numViaticos";
            numViaticos.Size = new Size(167, 23);
            numViaticos.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 396);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 21;
            label13.Text = "Monto Productos";
            // 
            // numProductos
            // 
            numProductos.DecimalPlaces = 2;
            numProductos.ForeColor = SystemColors.ActiveCaptionText;
            numProductos.Location = new Point(140, 394);
            numProductos.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numProductos.Name = "numProductos";
            numProductos.Size = new Size(167, 23);
            numProductos.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 367);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 19;
            label12.Text = "Monto Material";
            // 
            // numMaterial
            // 
            numMaterial.DecimalPlaces = 2;
            numMaterial.ForeColor = SystemColors.ActiveCaptionText;
            numMaterial.Location = new Point(140, 365);
            numMaterial.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMaterial.Name = "numMaterial";
            numMaterial.Size = new Size(167, 23);
            numMaterial.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 338);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 17;
            label11.Text = "Monto Kilometraje";
            // 
            // numKilometraje
            // 
            numKilometraje.DecimalPlaces = 2;
            numKilometraje.ForeColor = SystemColors.ActiveCaptionText;
            numKilometraje.Location = new Point(140, 336);
            numKilometraje.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numKilometraje.Name = "numKilometraje";
            numKilometraje.Size = new Size(167, 23);
            numKilometraje.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 309);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 15;
            label10.Text = "Monto Mano Obra";
            // 
            // numMO
            // 
            numMO.DecimalPlaces = 2;
            numMO.ForeColor = SystemColors.ActiveCaptionText;
            numMO.Location = new Point(140, 307);
            numMO.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMO.Name = "numMO";
            numMO.Size = new Size(167, 23);
            numMO.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 280);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 13;
            label9.Text = "Dias Laborables";
            // 
            // numDiasLaborales
            // 
            numDiasLaborales.DecimalPlaces = 2;
            numDiasLaborales.ForeColor = SystemColors.ActiveCaptionText;
            numDiasLaborales.Location = new Point(140, 278);
            numDiasLaborales.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDiasLaborales.Name = "numDiasLaborales";
            numDiasLaborales.Size = new Size(167, 23);
            numDiasLaborales.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 251);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 11;
            label8.Text = "Trabajadores";
            // 
            // numTrabajadores
            // 
            numTrabajadores.DecimalPlaces = 2;
            numTrabajadores.ForeColor = SystemColors.ActiveCaptionText;
            numTrabajadores.Location = new Point(140, 249);
            numTrabajadores.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numTrabajadores.Name = "numTrabajadores";
            numTrabajadores.Size = new Size(167, 23);
            numTrabajadores.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 196);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 8;
            label7.Text = "Direccion";
            // 
            // cbOferta
            // 
            cbOferta.ForeColor = SystemColors.ActiveCaptionText;
            cbOferta.FormattingEnabled = true;
            cbOferta.Location = new Point(140, 510);
            cbOferta.Name = "cbOferta";
            cbOferta.Size = new Size(167, 23);
            cbOferta.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            txtDescripcion.Location = new Point(140, 87);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(167, 71);
            txtDescripcion.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.ForeColor = SystemColors.ActiveCaptionText;
            txtTitulo.Location = new Point(140, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(167, 23);
            txtTitulo.TabIndex = 5;
            // 
            // txtCliente
            // 
            txtCliente.ForeColor = SystemColors.ActiveCaptionText;
            txtCliente.Location = new Point(140, 29);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(167, 23);
            txtCliente.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 513);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 3;
            label6.Text = "Número Oferta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 90);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 2;
            label5.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 58);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 32);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnBuscarLimpiar);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtBuscarCLiente);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(340, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 70);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(199, 32);
            label18.Name = "label18";
            label18.Size = new Size(40, 15);
            label18.TabIndex = 7;
            label18.Text = "Oferta";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(249, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 23);
            textBox1.TabIndex = 6;
            // 
            // btnBuscarLimpiar
            // 
            btnBuscarLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarLimpiar.Location = new Point(460, 27);
            btnBuscarLimpiar.Name = "btnBuscarLimpiar";
            btnBuscarLimpiar.Size = new Size(81, 23);
            btnBuscarLimpiar.TabIndex = 5;
            btnBuscarLimpiar.Text = "Limpiar";
            btnBuscarLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(353, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // txtBuscarCLiente
            // 
            txtBuscarCLiente.Location = new Point(70, 26);
            txtBuscarCLiente.Name = "txtBuscarCLiente";
            txtBuscarCLiente.Size = new Size(122, 23);
            txtBuscarCLiente.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dataGridViewCotizaciones);
            groupBox3.Location = new Point(340, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(740, 613);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dataGridViewCotizaciones
            // 
            dataGridViewCotizaciones.AllowUserToAddRows = false;
            dataGridViewCotizaciones.AllowUserToDeleteRows = false;
            dataGridViewCotizaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCotizaciones.Location = new Point(18, 22);
            dataGridViewCotizaciones.Name = "dataGridViewCotizaciones";
            dataGridViewCotizaciones.ReadOnly = true;
            dataGridViewCotizaciones.RowTemplate.Height = 25;
            dataGridViewCotizaciones.Size = new Size(708, 585);
            dataGridViewCotizaciones.TabIndex = 0;
            dataGridViewCotizaciones.CellContentClick += dataGridViewCotizaciones_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1093, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agToolStripMenuItem
            // 
            agToolStripMenuItem.Name = "agToolStripMenuItem";
            agToolStripMenuItem.Size = new Size(97, 20);
            agToolStripMenuItem.Text = "Agregar Oferta";
            agToolStripMenuItem.Click += agToolStripMenuItem_Click;
            // 
            // ListaCotizaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1093, 727);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ListaCotizaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista Cotizaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numImprevisto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numViaticos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKilometraje).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMO).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiasLaborales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTrabajadores).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCotizaciones).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Button btnBuscarLimpiar;
        private Button btnBuscar;
        private Label label2;
        private TextBox txtBuscarCLiente;
        private DataGridView dataGridViewCotizaciones;
        private TextBox txtTitulo;
        private TextBox txtCliente;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label7;
        private ComboBox cbOferta;
        private Label label11;
        private NumericUpDown numKilometraje;
        private Label label10;
        private NumericUpDown numMO;
        private Label label9;
        private NumericUpDown numDiasLaborales;
        private Label label8;
        private NumericUpDown numTrabajadores;
        private Label label15;
        private NumericUpDown numImprevisto;
        private Label label14;
        private NumericUpDown numViaticos;
        private Label label13;
        private NumericUpDown numProductos;
        private Label label12;
        private NumericUpDown numMaterial;
        private Button btnLimpiar;
        private Button btnAgregar;
        private CheckBox ckPuPri;
        private Label label16;
        private Label label17;
        private NumericUpDown numTotal;
        private Label label18;
        private TextBox textBox1;
        private ComboBox cbProvincia;
        private Label label19;
        private TextBox txtDireccion;
        private ComboBox comboBoxCategoria;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agToolStripMenuItem;
    }
}