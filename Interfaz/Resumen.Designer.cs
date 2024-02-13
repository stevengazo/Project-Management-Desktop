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
            groupBox1 = new GroupBox();
            dataGridViewPendientes = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewFinalizados = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewPendientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proyectos Pendientes";
            // 
            // dataGridViewPendientes
            // 
            dataGridViewPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPendientes.Location = new Point(6, 22);
            dataGridViewPendientes.Name = "dataGridViewPendientes";
            dataGridViewPendientes.RowTemplate.Height = 25;
            dataGridViewPendientes.Size = new Size(748, 257);
            dataGridViewPendientes.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridViewFinalizados);
            groupBox2.Location = new Point(12, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 261);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proyectos Finalizados";
            // 
            // dataGridViewFinalizados
            // 
            dataGridViewFinalizados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinalizados.Location = new Point(6, 22);
            dataGridViewFinalizados.Name = "dataGridViewFinalizados";
            dataGridViewFinalizados.RowTemplate.Height = 25;
            dataGridViewFinalizados.Size = new Size(748, 233);
            dataGridViewFinalizados.TabIndex = 1;
            // 
            // Resumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 576);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Resumen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resumen";
            Load += Resumen_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendientes).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewPendientes;
        private GroupBox groupBox2;
        private DataGridView dataGridViewFinalizados;
    }
}