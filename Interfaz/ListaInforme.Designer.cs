namespace Interfaz
{
    partial class ListaInforme
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
            dataGridViewInformes = new DataGridView();
            menuStrip1 = new MenuStrip();
            crearInformeToolStripMenuItem = new ToolStripMenuItem();
            informesPendientesToolStripMenuItem = new ToolStripMenuItem();
            groupBox3 = new GroupBox();
            dateTimePickerFinalizacion = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            trackBarCalificacion = new TrackBar();
            comboBoxAutor = new ComboBox();
            dateTimePickerEntrega = new DateTimePicker();
            btnActualizar = new Button();
            comboBoxEstado = new ComboBox();
            label9 = new Label();
            txtComentarios = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtTecnico = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtIdInforme = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformes).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarCalificacion).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewInformes);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 518);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Informes";
            // 
            // dataGridViewInformes
            // 
            dataGridViewInformes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInformes.Location = new Point(10, 28);
            dataGridViewInformes.Name = "dataGridViewInformes";
            dataGridViewInformes.RowTemplate.Height = 25;
            dataGridViewInformes.Size = new Size(759, 484);
            dataGridViewInformes.TabIndex = 0;
            dataGridViewInformes.CellClick += dataGridViewInformes_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearInformeToolStripMenuItem, informesPendientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1078, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearInformeToolStripMenuItem
            // 
            crearInformeToolStripMenuItem.Name = "crearInformeToolStripMenuItem";
            crearInformeToolStripMenuItem.Size = new Size(92, 20);
            crearInformeToolStripMenuItem.Text = "Crear Informe";
            crearInformeToolStripMenuItem.Click += crearInformeToolStripMenuItem_Click;
            // 
            // informesPendientesToolStripMenuItem
            // 
            informesPendientesToolStripMenuItem.Name = "informesPendientesToolStripMenuItem";
            informesPendientesToolStripMenuItem.Size = new Size(127, 20);
            informesPendientesToolStripMenuItem.Text = "Informes Pendientes";
            informesPendientesToolStripMenuItem.Click += informesPendientesToolStripMenuItem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtDescripcion);
            groupBox3.Controls.Add(dateTimePickerFinalizacion);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(trackBarCalificacion);
            groupBox3.Controls.Add(comboBoxAutor);
            groupBox3.Controls.Add(dateTimePickerEntrega);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(comboBoxEstado);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtComentarios);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTecnico);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtIdInforme);
            groupBox3.Location = new Point(793, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 518);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion";
            // 
            // dateTimePickerFinalizacion
            // 
            dateTimePickerFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerFinalizacion.CustomFormat = "\"YY/MM/DD\"";
            dateTimePickerFinalizacion.Location = new Point(116, 130);
            dateTimePickerFinalizacion.Name = "dateTimePickerFinalizacion";
            dateTimePickerFinalizacion.Size = new Size(151, 23);
            dateTimePickerFinalizacion.TabIndex = 24;
            dateTimePickerFinalizacion.Value = new DateTime(2024, 1, 15, 17, 29, 38, 0);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(9, 134);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 23;
            label13.Text = "Finalizacion";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(210, 254);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 22;
            label12.Text = "Excelente";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(9, 254);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 21;
            label11.Text = "Mal";
            // 
            // trackBarCalificacion
            // 
            trackBarCalificacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBarCalificacion.Location = new Point(60, 239);
            trackBarCalificacion.Maximum = 5;
            trackBarCalificacion.Minimum = 1;
            trackBarCalificacion.Name = "trackBarCalificacion";
            trackBarCalificacion.Size = new Size(144, 45);
            trackBarCalificacion.TabIndex = 20;
            trackBarCalificacion.Value = 1;
            // 
            // comboBoxAutor
            // 
            comboBoxAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAutor.FormattingEnabled = true;
            comboBoxAutor.Location = new Point(116, 167);
            comboBoxAutor.Name = "comboBoxAutor";
            comboBoxAutor.Size = new Size(151, 23);
            comboBoxAutor.TabIndex = 19;
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEntrega.CustomFormat = "\"YY/MM/DD\"";
            dateTimePickerEntrega.Location = new Point(116, 101);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(151, 23);
            dateTimePickerEntrega.TabIndex = 18;
            dateTimePickerEntrega.Value = new DateTime(2024, 1, 15, 17, 29, 38, 0);
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.Location = new Point(67, 471);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 23);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pendiente", "En Ejecución", "En revisión", "Finalizado" });
            comboBoxEstado.Location = new Point(116, 73);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(151, 23);
            comboBoxEstado.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(9, 287);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 13;
            label9.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComentarios.Location = new Point(9, 305);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(258, 66);
            txtComentarios.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(9, 226);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 11;
            label8.Text = "Calificación";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(9, 199);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 9;
            label7.Text = "Técnico";
            // 
            // txtTecnico
            // 
            txtTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTecnico.Location = new Point(116, 196);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(151, 23);
            txtTecnico.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(9, 170);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 7;
            label6.Text = "Autor";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(9, 105);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha Entrega";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(9, 76);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(9, 47);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 1;
            label3.Text = "Id Informe";
            // 
            // txtIdInforme
            // 
            txtIdInforme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdInforme.Location = new Point(116, 44);
            txtIdInforme.Name = "txtIdInforme";
            txtIdInforme.ReadOnly = true;
            txtIdInforme.Size = new Size(151, 23);
            txtIdInforme.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(9, 381);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 26;
            label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(9, 399);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(258, 66);
            txtDescripcion.TabIndex = 25;
            // 
            // ListaInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 565);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListaInforme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Informe";
            Load += ListaInforme_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarCalificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewInformes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearInformeToolStripMenuItem;
        private ToolStripMenuItem informesPendientesToolStripMenuItem;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtIdInforme;
        private Label label9;
        private TextBox txtComentarios;
        private Label label8;
        private Label label7;
        private TextBox txtTecnico;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerEntrega;
        private Button btnActualizar;
        private ComboBox comboBoxEstado;
        private TrackBar trackBarCalificacion;
        private ComboBox comboBoxAutor;
        private Label label12;
        private Label label11;
        private DateTimePicker dateTimePickerFinalizacion;
        private Label label13;
        private Label label1;
        private TextBox txtDescripcion;
    }
}