namespace Interfaz
{
    partial class ListarOferta
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
            dgvOfertas = new DataGridView();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            agregarOfertaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            buttonExportar = new Button();
            BtnLimpar = new Button();
            btnBuscar = new Button();
            txtCliente = new TextBox();
            label3 = new Label();
            txtNumeroOferta = new TextBox();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvOfertas).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOfertas
            // 
            dgvOfertas.AllowUserToAddRows = false;
            dgvOfertas.AllowUserToDeleteRows = false;
            dgvOfertas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOfertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOfertas.Location = new Point(12, 92);
            dgvOfertas.Name = "dgvOfertas";
            dgvOfertas.ReadOnly = true;
            dgvOfertas.RowTemplate.Height = 25;
            dgvOfertas.Size = new Size(1277, 491);
            dgvOfertas.TabIndex = 0;
            dgvOfertas.CellContentClick += dgvOfertas_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, agregarOfertaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1301, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // agregarOfertaToolStripMenuItem
            // 
            agregarOfertaToolStripMenuItem.Name = "agregarOfertaToolStripMenuItem";
            agregarOfertaToolStripMenuItem.Size = new Size(97, 20);
            agregarOfertaToolStripMenuItem.Text = "Agregar Oferta";
            agregarOfertaToolStripMenuItem.Click += agregarOfertaToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonExportar);
            groupBox1.Controls.Add(BtnLimpar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumeroOferta);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 59);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // buttonExportar
            // 
            buttonExportar.Location = new Point(877, 23);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(105, 23);
            buttonExportar.TabIndex = 8;
            buttonExportar.Text = "Exportar";
            buttonExportar.UseVisualStyleBackColor = true;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(756, 24);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(105, 23);
            BtnLimpar.TabIndex = 7;
            BtnLimpar.Text = "Limpiar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(632, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(396, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Mecsa";
            txtCliente.Size = new Size(180, 23);
            txtCliente.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 28);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Cliente";
            // 
            // txtNumeroOferta
            // 
            txtNumeroOferta.Location = new Point(123, 24);
            txtNumeroOferta.Name = "txtNumeroOferta";
            txtNumeroOferta.PlaceholderText = "1234565";
            txtNumeroOferta.Size = new Size(180, 23);
            txtNumeroOferta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Oferta";
            // 
            // ListarOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 595);
            Controls.Add(groupBox1);
            Controls.Add(dgvOfertas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListarOferta";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Ofertas";
            Load += ListarOferta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOfertas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOfertas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem agregarOfertaToolStripMenuItem;
        private GroupBox groupBox1;
        private Button BtnLimpar;
        private Button btnBuscar;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtNumeroOferta;
        private Label label1;
        private Button buttonExportar;
        private SaveFileDialog saveFileDialog1;
    }
}