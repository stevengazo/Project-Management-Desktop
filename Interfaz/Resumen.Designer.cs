namespace Interfaz
{
    partial class Resumen
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
            dataGridViewPendientes = new DataGridView();
            dataGridViewFinalizados = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnPendientes = new Button();
            tabPage2 = new TabPage();
            btnFinalizados = new Button();
            tabPage3 = new TabPage();
            btnSinFacturar = new Button();
            dataGridViewSinFacturar = new DataGridView();
            tabPage4 = new TabPage();
            btnFacturados = new Button();
            dataGridViewFacturados = new DataGridView();
            saveFileDialogExcel = new SaveFileDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinFacturar).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPendientes
            // 
            dataGridViewPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPendientes.Location = new Point(6, 37);
            dataGridViewPendientes.Name = "dataGridViewPendientes";
            dataGridViewPendientes.RowTemplate.Height = 25;
            dataGridViewPendientes.Size = new Size(870, 494);
            dataGridViewPendientes.TabIndex = 0;
            dataGridViewPendientes.CellContentClick += dataGridViewPendientes_CellContentClick;
            // 
            // dataGridViewFinalizados
            // 
            dataGridViewFinalizados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinalizados.Location = new Point(6, 37);
            dataGridViewFinalizados.Name = "dataGridViewFinalizados";
            dataGridViewFinalizados.RowTemplate.Height = 25;
            dataGridViewFinalizados.Size = new Size(870, 494);
            dataGridViewFinalizados.TabIndex = 1;
            dataGridViewFinalizados.CellContentClick += dataGridViewFinalizados_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 565);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPendientes);
            tabPage1.Controls.Add(dataGridViewPendientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pendientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPendientes
            // 
            btnPendientes.Location = new Point(6, 6);
            btnPendientes.Name = "btnPendientes";
            btnPendientes.Size = new Size(150, 23);
            btnPendientes.TabIndex = 1;
            btnPendientes.Text = "Exportado";
            btnPendientes.UseVisualStyleBackColor = true;
            btnPendientes.Click += btnPendientes_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnFinalizados);
            tabPage2.Controls.Add(dataGridViewFinalizados);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Finalizados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFinalizados
            // 
            btnFinalizados.Location = new Point(6, 8);
            btnFinalizados.Name = "btnFinalizados";
            btnFinalizados.Size = new Size(150, 23);
            btnFinalizados.TabIndex = 2;
            btnFinalizados.Text = "Exportado";
            btnFinalizados.UseVisualStyleBackColor = true;
            btnFinalizados.Click += btnFinalizados_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSinFacturar);
            tabPage3.Controls.Add(dataGridViewSinFacturar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(882, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sin Facturar";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // btnSinFacturar
            // 
            btnSinFacturar.Location = new Point(6, 7);
            btnSinFacturar.Name = "btnSinFacturar";
            btnSinFacturar.Size = new Size(150, 23);
            btnSinFacturar.TabIndex = 3;
            btnSinFacturar.Text = "Exportado";
            btnSinFacturar.UseVisualStyleBackColor = true;
            btnSinFacturar.Click += btnSinFacturar_Click;
            // 
            // dataGridViewSinFacturar
            // 
            dataGridViewSinFacturar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSinFacturar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinFacturar.Location = new Point(6, 36);
            dataGridViewSinFacturar.Name = "dataGridViewSinFacturar";
            dataGridViewSinFacturar.RowTemplate.Height = 25;
            dataGridViewSinFacturar.Size = new Size(870, 479);
            dataGridViewSinFacturar.TabIndex = 1;
            dataGridViewSinFacturar.CellContentClick += dataGridViewSinFacturar_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnFacturados);
            tabPage4.Controls.Add(dataGridViewFacturados);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(882, 537);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Facturados";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnFacturados
            // 
            btnFacturados.Location = new Point(6, 6);
            btnFacturados.Name = "btnFacturados";
            btnFacturados.Size = new Size(150, 23);
            btnFacturados.TabIndex = 4;
            btnFacturados.Text = "Exportado";
            btnFacturados.UseVisualStyleBackColor = true;
            btnFacturados.Click += btnFacturados_Click;
            // 
            // dataGridViewFacturados
            // 
            dataGridViewFacturados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFacturados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFacturados.Location = new Point(6, 35);
            dataGridViewFacturados.Name = "dataGridViewFacturados";
            dataGridViewFacturados.RowTemplate.Height = 25;
            dataGridViewFacturados.Size = new Size(870, 480);
            dataGridViewFacturados.TabIndex = 1;
            dataGridViewFacturados.CellContentClick += dataGridViewFacturados_CellContentClick;
            // 
            // Resumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 576);
            Controls.Add(tabControl1);
            Name = "Resumen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resumen";
            Load += Resumen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinFacturar).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewPendientes;
        private DataGridView dataGridViewFinalizados;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridViewSinFacturar;
        private DataGridView dataGridViewFacturados;
        private Button btnPendientes;
        private Button btnFinalizados;
        private Button btnSinFacturar;
        private Button btnFacturados;
        private SaveFileDialog saveFileDialogExcel;
        private SaveFileDialog saveFileDialog;
    }
}