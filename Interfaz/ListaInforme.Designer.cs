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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            crearInformeToolStripMenuItem = new ToolStripMenuItem();
            calificacionesToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            informesPendientesToolStripMenuItem = new ToolStripMenuItem();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Informes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(759, 417);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearInformeToolStripMenuItem, informesPendientesToolStripMenuItem, calificacionesToolStripMenuItem });
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
            // 
            // calificacionesToolStripMenuItem
            // 
            calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            calificacionesToolStripMenuItem.Size = new Size(92, 20);
            calificacionesToolStripMenuItem.Text = "Calificaciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 67);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(495, 30);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(793, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 518);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion";
            // 
            // informesPendientesToolStripMenuItem
            // 
            informesPendientesToolStripMenuItem.Name = "informesPendientesToolStripMenuItem";
            informesPendientesToolStripMenuItem.Size = new Size(127, 20);
            informesPendientesToolStripMenuItem.Text = "Informes Pendientes";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 47);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 76);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 105);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 23);
            textBox5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 134);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(116, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 23);
            textBox6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 163);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(116, 160);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 23);
            textBox7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 192);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 11;
            label8.Text = "label8";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(116, 189);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(151, 23);
            textBox8.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 221);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 13;
            label9.Text = "label9";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(116, 218);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(151, 23);
            textBox9.TabIndex = 12;
            // 
            // ListaInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 559);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListaInforme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Informe";
            Load += ListaInforme_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearInformeToolStripMenuItem;
        private ToolStripMenuItem calificacionesToolStripMenuItem;
        private GroupBox groupBox2;
        private ToolStripMenuItem informesPendientesToolStripMenuItem;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
    }
}