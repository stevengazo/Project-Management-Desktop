namespace Interfaz
{
    partial class InformesPendientes
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
            dataGridViewPendientes = new DataGridView();
            groupBox3 = new GroupBox();
            label1 = new Label();
            comboBoxAutor = new ComboBox();
            btnActualizar = new Button();
            comboBoxEstado = new ComboBox();
            label7 = new Label();
            txtTecnico = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtIdInforme = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewPendientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 520);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informes Pendientes";
            // 
            // dataGridViewPendientes
            // 
            dataGridViewPendientes.AllowUserToAddRows = false;
            dataGridViewPendientes.AllowUserToDeleteRows = false;
            dataGridViewPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPendientes.Location = new Point(6, 22);
            dataGridViewPendientes.Name = "dataGridViewPendientes";
            dataGridViewPendientes.ReadOnly = true;
            dataGridViewPendientes.RowTemplate.Height = 25;
            dataGridViewPendientes.Size = new Size(742, 492);
            dataGridViewPendientes.TabIndex = 0;
            dataGridViewPendientes.CellClick += dataGridViewPendientes_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(comboBoxAutor);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(comboBoxEstado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTecnico);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtIdInforme);
            groupBox3.Location = new Point(772, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(205, 518);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 235);
            label1.Name = "label1";
            label1.Size = new Size(146, 90);
            label1.TabIndex = 20;
            label1.Text = "Recomendación\r\n\r\nSelecciona uno de \r\nlos últimos informes\r\ndisponibles o consulta\r\ncual tiene mayor prioridad";
            label1.Click += label1_Click;
            // 
            // comboBoxAutor
            // 
            comboBoxAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAutor.FormattingEnabled = true;
            comboBoxAutor.Location = new Point(6, 126);
            comboBoxAutor.Name = "comboBoxAutor";
            comboBoxAutor.Size = new Size(193, 23);
            comboBoxAutor.TabIndex = 19;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.Location = new Point(58, 199);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(79, 23);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pendiente", "En Ejecución", "En revisión", "Finalizado" });
            comboBoxEstado.Location = new Point(6, 82);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(193, 23);
            comboBoxEstado.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(6, 152);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 9;
            label7.Text = "Técnico";
            // 
            // txtTecnico
            // 
            txtTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTecnico.Location = new Point(6, 170);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(193, 23);
            txtTecnico.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(6, 108);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 7;
            label6.Text = "Encargado";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 64);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 20);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 1;
            label3.Text = "Id Informe";
            // 
            // txtIdInforme
            // 
            txtIdInforme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdInforme.Location = new Point(6, 38);
            txtIdInforme.Name = "txtIdInforme";
            txtIdInforme.Size = new Size(193, 23);
            txtIdInforme.TabIndex = 0;
            // 
            // InformesPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 544);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "InformesPendientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informes Pendientes";
            Load += InformesPendientes_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewPendientes;
        private GroupBox groupBox3;
        private ComboBox comboBoxAutor;
        private Button btnActualizar;
        private ComboBox comboBoxEstado;
        private Label label7;
        private TextBox txtTecnico;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtIdInforme;
        private Label label1;
    }
}