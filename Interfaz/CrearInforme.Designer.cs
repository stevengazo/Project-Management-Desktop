namespace Interfaz
{
    partial class CrearInforme
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
            dateTimePickerEntrega = new DateTimePicker();
            btnCrear = new Button();
            comboBoxProyectoId = new ComboBox();
            comboBoxEstado = new ComboBox();
            label10 = new Label();
            label7 = new Label();
            txtTecnico = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEntrega.CustomFormat = "\"YY/MM/DD\"";
            dateTimePickerEntrega.Location = new Point(126, 40);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(177, 23);
            dateTimePickerEntrega.TabIndex = 39;
            dateTimePickerEntrega.Value = new DateTime(2024, 1, 15, 17, 29, 38, 0);
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCrear.Location = new Point(86, 139);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(109, 23);
            btnCrear.TabIndex = 38;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // comboBoxProyectoId
            // 
            comboBoxProyectoId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProyectoId.FormattingEnabled = true;
            comboBoxProyectoId.Location = new Point(126, 98);
            comboBoxProyectoId.Name = "comboBoxProyectoId";
            comboBoxProyectoId.Size = new Size(177, 23);
            comboBoxProyectoId.TabIndex = 37;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pendiente", "En Ejecución", "En revisión", "Finalizado" });
            comboBoxEstado.Location = new Point(126, 12);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(177, 23);
            comboBoxEstado.TabIndex = 36;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(19, 101);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 35;
            label10.Text = "Número Proyecto";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(19, 72);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 31;
            label7.Text = "Técnico";
            // 
            // txtTecnico
            // 
            txtTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTecnico.Location = new Point(126, 69);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(177, 23);
            txtTecnico.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(19, 44);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 28;
            label5.Text = "Fecha Entrega";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(19, 15);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 27;
            label4.Text = "Estado";
            // 
            // CrearInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 173);
            Controls.Add(dateTimePickerEntrega);
            Controls.Add(btnCrear);
            Controls.Add(comboBoxProyectoId);
            Controls.Add(comboBoxEstado);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtTecnico);
            Controls.Add(label5);
            Controls.Add(label4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearInforme";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Informe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePickerEntrega;
        private Button btnCrear;
        private ComboBox comboBoxProyectoId;
        private ComboBox comboBoxEstado;
        private Label label10;
        private Label label7;
        private TextBox txtTecnico;
        private Label label5;
        private Label label4;
    }
}