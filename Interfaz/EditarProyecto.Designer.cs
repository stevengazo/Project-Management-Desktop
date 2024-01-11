namespace Interfaz
{
    partial class EditarProyecto
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
            txtOferta = new TextBox();
            cbProvincia = new ComboBox();
            label18 = new Label();
            cbTipoTrabajo = new ComboBox();
            label12 = new Label();
            label2 = new Label();
            txtNota = new TextBox();
            txtFacturalFinalId = new TextBox();
            label1 = new Label();
            btnBorrar = new Button();
            txtRazonSocial = new TextBox();
            txtidProyecto = new TextBox();
            label6 = new Label();
            dtpOC = new DateTimePicker();
            cbVendedores = new ComboBox();
            cbEstado = new ComboBox();
            numericUpDownPorcentaje = new NumericUpDown();
            dtpFinalizacion = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            btnAgregar = new Button();
            button2 = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtUbicacion = new TextBox();
            label14 = new Label();
            txtTarea = new TextBox();
            label13 = new Label();
            txtNumeroFacturaAnticipo = new TextBox();
            label11 = new Label();
            txtMonto = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtContacto = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOferta);
            groupBox1.Controls.Add(cbProvincia);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(cbTipoTrabajo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNota);
            groupBox1.Controls.Add(txtFacturalFinalId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(txtidProyecto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpOC);
            groupBox1.Controls.Add(cbVendedores);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(numericUpDownPorcentaje);
            groupBox1.Controls.Add(dtpFinalizacion);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtTarea);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtNumeroFacturaAnticipo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 731);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Proyecto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtOferta
            // 
            txtOferta.Location = new Point(181, 188);
            txtOferta.Name = "txtOferta";
            txtOferta.Size = new Size(225, 23);
            txtOferta.TabIndex = 51;
            // 
            // cbProvincia
            // 
            cbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Limón", "Puntarenas", "Guanacaste", "Internacional" });
            cbProvincia.Location = new Point(181, 521);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(225, 23);
            cbProvincia.TabIndex = 50;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 524);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 49;
            label18.Text = "Provincia";
            // 
            // cbTipoTrabajo
            // 
            cbTipoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTrabajo.FormattingEnabled = true;
            cbTipoTrabajo.Items.AddRange(new object[] { "DDCE - Instalación", "DDCE - Mantenimiento", "DDCE - Mejoras", "Ionizante - Instalación", "Ionizante - Mantenimiento", "Ionizante - Mejoras", "Mallas - Instalación", "Mallas - Mantenimiento", "Mallas - Mejora", "Supresores - Instalación", "Trabajo Eléctrico", "Otro" });
            cbTipoTrabajo.Location = new Point(181, 614);
            cbTipoTrabajo.Name = "cbTipoTrabajo";
            cbTipoTrabajo.Size = new Size(225, 23);
            cbTipoTrabajo.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 614);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 47;
            label12.Text = "Tipo Trabajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 359);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 46;
            label2.Text = "Notas";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(181, 359);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(225, 75);
            txtNota.TabIndex = 45;
            // 
            // txtFacturalFinalId
            // 
            txtFacturalFinalId.Location = new Point(181, 301);
            txtFacturalFinalId.Name = "txtFacturalFinalId";
            txtFacturalFinalId.Size = new Size(225, 23);
            txtFacturalFinalId.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 304);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 43;
            label1.Text = "Numero Factural Final";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightCoral;
            btnBorrar.Location = new Point(33, 685);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 23);
            btnBorrar.TabIndex = 41;
            btnBorrar.Text = "Borrar Proyecto";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(181, 95);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(225, 23);
            txtRazonSocial.TabIndex = 6;
            // 
            // txtidProyecto
            // 
            txtidProyecto.Location = new Point(181, 29);
            txtidProyecto.Name = "txtidProyecto";
            txtidProyecto.ReadOnly = true;
            txtidProyecto.Size = new Size(225, 23);
            txtidProyecto.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 32);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 39;
            label6.Text = "Id Interno";
            // 
            // dtpOC
            // 
            dtpOC.Location = new Point(181, 127);
            dtpOC.Name = "dtpOC";
            dtpOC.Size = new Size(225, 23);
            dtpOC.TabIndex = 38;
            // 
            // cbVendedores
            // 
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(181, 58);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(225, 23);
            cbVendedores.TabIndex = 37;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente de Ejecución", "En ejecución", "Finalizado con cobro", "Finalizado sin cobro" });
            cbEstado.Location = new Point(181, 646);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(225, 23);
            cbEstado.TabIndex = 36;
            // 
            // numericUpDownPorcentaje
            // 
            numericUpDownPorcentaje.Location = new Point(181, 246);
            numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            numericUpDownPorcentaje.Size = new Size(225, 23);
            numericUpDownPorcentaje.TabIndex = 35;
            // 
            // dtpFinalizacion
            // 
            dtpFinalizacion.Location = new Point(180, 585);
            dtpFinalizacion.Name = "dtpFinalizacion";
            dtpFinalizacion.Size = new Size(225, 23);
            dtpFinalizacion.TabIndex = 34;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(181, 550);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(225, 23);
            dtpInicio.TabIndex = 33;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SkyBlue;
            btnAgregar.Location = new Point(270, 685);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Actualizar Proyecto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 685);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 646);
            label17.Name = "label17";
            label17.Size = new Size(42, 15);
            label17.TabIndex = 28;
            label17.Text = "Estado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 585);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 26;
            label16.Text = "Fecha Finalización";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 550);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 24;
            label15.Text = "Fecha Inicio";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(181, 440);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(225, 75);
            txtUbicacion.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 443);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 22;
            label14.Text = "Ubicación";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(181, 330);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(225, 23);
            txtTarea.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 333);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 20;
            label13.Text = "Tarea Bitrix";
            // 
            // txtNumeroFacturaAnticipo
            // 
            txtNumeroFacturaAnticipo.Location = new Point(181, 272);
            txtNumeroFacturaAnticipo.Name = "txtNumeroFacturaAnticipo";
            txtNumeroFacturaAnticipo.Size = new Size(225, 23);
            txtNumeroFacturaAnticipo.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 275);
            label11.Name = "label11";
            label11.Size = new Size(141, 15);
            label11.TabIndex = 16;
            label11.Text = "Número Factura Anticipo";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(181, 217);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(225, 23);
            txtMonto.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 246);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 14;
            label10.Text = "Porcentaje Anticipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 217);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 12;
            label9.Text = "Monto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 188);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 10;
            label8.Text = "Oferta Mecsa";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(181, 156);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(225, 23);
            txtContacto.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 159);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 8;
            label7.Text = "Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 130);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 2;
            label5.Text = "Fecha Orden Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 98);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "Razon Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 66);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Vendedor";
            // 
            // EditarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 751);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarProyecto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Proyecto";
            Load += EditarProyecto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRazonSocial;
        private TextBox txtidProyecto;
        private Label label6;
        private DateTimePicker dtpOC;
        private ComboBox cbVendedores;
        private ComboBox cbEstado;
        private NumericUpDown numericUpDownPorcentaje;
        private DateTimePicker dtpFinalizacion;
        private DateTimePicker dtpInicio;
        private Button btnAgregar;
        private Button button2;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtUbicacion;
        private Label label14;
        private TextBox txtTarea;
        private Label label13;
        private TextBox txtNumeroFacturaAnticipo;
        private Label label11;
        private TextBox txtMonto;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtContacto;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnBorrar;
        private TextBox txtFacturalFinalId;
        private Label label1;
        private Label label2;
        private TextBox txtNota;
        private ComboBox cbTipoTrabajo;
        private Label label12;
        private ComboBox cbProvincia;
        private Label label18;
        private TextBox txtOferta;
    }
}