namespace POE_proyecto.Vista
{
    partial class FormGestionMantenimientos
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
            btnEnviarDatosMantenimiento = new Button();
            label26 = new Label();
            label25 = new Label();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            label22 = new Label();
            lblMantenimientoInfo = new Label();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            btnCrearMantenimiento = new Button();
            btnEditarMantenimiento = new Button();
            lblCodigoMantenimiento = new Label();
            lblMantenimientoTitle = new Label();
            btnBuscarMantenimiento = new Button();
            txtCodigoMantenimiento = new TextBox();
            dataGridViewClientes = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            textBox2 = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarDatosMantenimiento
            // 
            btnEnviarDatosMantenimiento.Location = new Point(24, 576);
            btnEnviarDatosMantenimiento.Name = "btnEnviarDatosMantenimiento";
            btnEnviarDatosMantenimiento.Size = new Size(427, 49);
            btnEnviarDatosMantenimiento.TabIndex = 8;
            btnEnviarDatosMantenimiento.Text = "Enviar";
            btnEnviarDatosMantenimiento.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label26.ForeColor = SystemColors.Control;
            label26.Location = new Point(14, 412);
            label26.Name = "label26";
            label26.Size = new Size(102, 28);
            label26.TabIndex = 21;
            label26.Text = "Servicios:";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label25.ForeColor = SystemColors.Control;
            label25.Location = new Point(14, 314);
            label25.Name = "label25";
            label25.Size = new Size(170, 56);
            label25.TabIndex = 19;
            label25.Text = "Fecha de Mantenimiento:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(14, 230);
            label18.Name = "label18";
            label18.Size = new Size(130, 28);
            label18.TabIndex = 15;
            label18.Text = "Diagnostico:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(14, 187);
            label19.Name = "label19";
            label19.Size = new Size(98, 28);
            label19.TabIndex = 13;
            label19.Text = "Vehiculo:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(14, 108);
            label21.Name = "label21";
            label21.Size = new Size(83, 28);
            label21.TabIndex = 9;
            label21.Text = "Cliente:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label22.ForeColor = SystemColors.Control;
            label22.Location = new Point(14, 148);
            label22.Name = "label22";
            label22.Size = new Size(108, 28);
            label22.TabIndex = 7;
            label22.Text = "Mecanico:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMantenimientoInfo
            // 
            lblMantenimientoInfo.AutoSize = true;
            lblMantenimientoInfo.BackColor = Color.FromArgb(25, 30, 70);
            lblMantenimientoInfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMantenimientoInfo.ForeColor = SystemColors.Control;
            lblMantenimientoInfo.Location = new Point(24, 47);
            lblMantenimientoInfo.Name = "lblMantenimientoInfo";
            lblMantenimientoInfo.Size = new Size(427, 37);
            lblMantenimientoInfo.TabIndex = 6;
            lblMantenimientoInfo.Text = "Información del Mantenimiento";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 30, 70);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(checkedListBox1);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(btnEnviarDatosMantenimiento);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(lblMantenimientoInfo);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(679, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 691);
            panel4.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(175, 532);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 23);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Correctivo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(175, 192);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(276, 23);
            comboBox3.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(175, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(276, 23);
            comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 23);
            comboBox1.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 72);
            textBox1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(175, 333);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(276, 23);
            dateTimePicker2.TabIndex = 23;
            // 
            // btnCrearMantenimiento
            // 
            btnCrearMantenimiento.Location = new Point(426, 107);
            btnCrearMantenimiento.Name = "btnCrearMantenimiento";
            btnCrearMantenimiento.Size = new Size(75, 23);
            btnCrearMantenimiento.TabIndex = 24;
            btnCrearMantenimiento.Text = "Crear";
            btnCrearMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnEditarMantenimiento
            // 
            btnEditarMantenimiento.Location = new Point(345, 107);
            btnEditarMantenimiento.Name = "btnEditarMantenimiento";
            btnEditarMantenimiento.Size = new Size(75, 23);
            btnEditarMantenimiento.TabIndex = 23;
            btnEditarMantenimiento.Text = "Editar";
            btnEditarMantenimiento.UseVisualStyleBackColor = true;
            // 
            // lblCodigoMantenimiento
            // 
            lblCodigoMantenimiento.AutoSize = true;
            lblCodigoMantenimiento.BackColor = Color.FromArgb(20, 37, 78);
            lblCodigoMantenimiento.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCodigoMantenimiento.ForeColor = SystemColors.Control;
            lblCodigoMantenimiento.Location = new Point(29, 102);
            lblCodigoMantenimiento.Name = "lblCodigoMantenimiento";
            lblCodigoMantenimiento.Size = new Size(83, 28);
            lblCodigoMantenimiento.TabIndex = 22;
            lblCodigoMantenimiento.Text = "Código:";
            lblCodigoMantenimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMantenimientoTitle
            // 
            lblMantenimientoTitle.AutoSize = true;
            lblMantenimientoTitle.BackColor = Color.FromArgb(20, 37, 78);
            lblMantenimientoTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMantenimientoTitle.ForeColor = SystemColors.Control;
            lblMantenimientoTitle.Location = new Point(29, 50);
            lblMantenimientoTitle.Name = "lblMantenimientoTitle";
            lblMantenimientoTitle.Size = new Size(368, 37);
            lblMantenimientoTitle.TabIndex = 21;
            lblMantenimientoTitle.Text = "Listado de Mantenimientos";
            // 
            // btnBuscarMantenimiento
            // 
            btnBuscarMantenimiento.Location = new Point(264, 107);
            btnBuscarMantenimiento.Name = "btnBuscarMantenimiento";
            btnBuscarMantenimiento.Size = new Size(75, 23);
            btnBuscarMantenimiento.TabIndex = 20;
            btnBuscarMantenimiento.Text = "Buscar";
            btnBuscarMantenimiento.UseVisualStyleBackColor = true;
            // 
            // txtCodigoMantenimiento
            // 
            txtCodigoMantenimiento.Location = new Point(116, 107);
            txtCodigoMantenimiento.Name = "txtCodigoMantenimiento";
            txtCodigoMantenimiento.Size = new Size(142, 23);
            txtCodigoMantenimiento.TabIndex = 19;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(29, 148);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ShowEditingIcon = false;
            dataGridViewClientes.Size = new Size(626, 354);
            dataGridViewClientes.TabIndex = 18;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(175, 387);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(276, 76);
            checkedListBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(14, 489);
            label1.Name = "label1";
            label1.Size = new Size(130, 64);
            label1.TabIndex = 30;
            label1.Text = "Trabajos Realizados:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 489);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 37);
            textBox2.TabIndex = 31;
            // 
            // FormGestionMantenimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(1159, 691);
            Controls.Add(btnCrearMantenimiento);
            Controls.Add(btnEditarMantenimiento);
            Controls.Add(lblCodigoMantenimiento);
            Controls.Add(lblMantenimientoTitle);
            Controls.Add(btnBuscarMantenimiento);
            Controls.Add(txtCodigoMantenimiento);
            Controls.Add(dataGridViewClientes);
            Controls.Add(panel4);
            Name = "FormGestionMantenimientos";
            Text = "Gestion de Mantenimientos";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarDatosMantenimiento;
        private DateTimePicker dateTimePicker1;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label lblMantenimientoInfo;
        private Panel panel4;
        private Button btnCrearMantenimiento;
        private Button btnEditarMantenimiento;
        private Label lblCodigoMantenimiento;
        private Label lblMantenimientoTitle;
        private Button btnBuscarMantenimiento;
        private TextBox txtCodigoMantenimiento;
        private DataGridView dataGridViewClientes;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox2;
        private Label label1;
    }
}