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
            dateTimePicker1 = new DateTimePicker();
            label26 = new Label();
            textBox22 = new TextBox();
            label25 = new Label();
            label24 = new Label();
            textBox20 = new TextBox();
            label18 = new Label();
            textBox15 = new TextBox();
            label19 = new Label();
            textBox16 = new TextBox();
            label20 = new Label();
            textBox17 = new TextBox();
            label21 = new Label();
            textBox18 = new TextBox();
            label22 = new Label();
            lblMantenimientoInfo = new Label();
            textBox19 = new TextBox();
            panel4 = new Panel();
            btnCrearMantenimiento = new Button();
            btnEditarMantenimiento = new Button();
            lblCodigoMantenimiento = new Label();
            lblMantenimientoTitle = new Label();
            btnBuscarMantenimiento = new Button();
            txtCodigoMantenimiento = new TextBox();
            dataGridViewClientes = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarDatosMantenimiento
            // 
            btnEnviarDatosMantenimiento.Location = new Point(24, 480);
            btnEnviarDatosMantenimiento.Name = "btnEnviarDatosMantenimiento";
            btnEnviarDatosMantenimiento.Size = new Size(396, 49);
            btnEnviarDatosMantenimiento.TabIndex = 8;
            btnEnviarDatosMantenimiento.Text = "Enviar";
            btnEnviarDatosMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(314, 587);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label26.ForeColor = SystemColors.Control;
            label26.Location = new Point(24, 418);
            label26.Name = "label26";
            label26.Size = new Size(118, 28);
            label26.TabIndex = 21;
            label26.Text = "Referencia:";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(175, 423);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(245, 23);
            textBox22.TabIndex = 20;
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label25.ForeColor = SystemColors.Control;
            label25.Location = new Point(24, 351);
            label25.Name = "label25";
            label25.Size = new Size(149, 56);
            label25.TabIndex = 19;
            label25.Text = "Fecha de nacimiento:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label24.ForeColor = SystemColors.Control;
            label24.Location = new Point(24, 306);
            label24.Name = "label24";
            label24.Size = new Size(99, 28);
            label24.TabIndex = 17;
            label24.Text = "Telefono:";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(175, 310);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(245, 23);
            textBox20.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(24, 269);
            label18.Name = "label18";
            label18.Size = new Size(80, 28);
            label18.TabIndex = 15;
            label18.Text = "Correo:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(175, 274);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(245, 23);
            textBox15.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(24, 233);
            label19.Name = "label19";
            label19.Size = new Size(107, 28);
            label19.TabIndex = 13;
            label19.Text = "Dirección:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(175, 237);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(245, 23);
            textBox16.TabIndex = 12;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(24, 194);
            label20.Name = "label20";
            label20.Size = new Size(105, 28);
            label20.TabIndex = 11;
            label20.Text = "Apellidos:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(175, 199);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(245, 23);
            textBox17.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(24, 121);
            label21.Name = "label21";
            label21.Size = new Size(81, 28);
            label21.TabIndex = 9;
            label21.Text = "Cedula:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(175, 126);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(245, 23);
            textBox18.TabIndex = 8;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label22.ForeColor = SystemColors.Control;
            label22.Location = new Point(24, 157);
            label22.Name = "label22";
            label22.Size = new Size(103, 28);
            label22.TabIndex = 7;
            label22.Text = "Nombres:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMantenimientoInfo
            // 
            lblMantenimientoInfo.AutoSize = true;
            lblMantenimientoInfo.BackColor = Color.FromArgb(25, 30, 70);
            lblMantenimientoInfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMantenimientoInfo.ForeColor = SystemColors.Control;
            lblMantenimientoInfo.Location = new Point(24, 59);
            lblMantenimientoInfo.Name = "lblMantenimientoInfo";
            lblMantenimientoInfo.Size = new Size(427, 37);
            lblMantenimientoInfo.TabIndex = 6;
            lblMantenimientoInfo.Text = "Información del Mantenimiento";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(175, 162);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(245, 23);
            textBox19.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 30, 70);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(btnEnviarDatosMantenimiento);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(textBox22);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(textBox20);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(textBox15);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(textBox16);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(textBox17);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(textBox18);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(lblMantenimientoInfo);
            panel4.Controls.Add(textBox19);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(679, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 553);
            panel4.TabIndex = 17;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(175, 361);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(245, 23);
            dateTimePicker2.TabIndex = 23;
            // 
            // FormGestionMantenimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(1159, 553);
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
        private TextBox textBox22;
        private Label label25;
        private Label label24;
        private TextBox textBox20;
        private Label label18;
        private TextBox textBox15;
        private Label label19;
        private TextBox textBox16;
        private Label label20;
        private TextBox textBox17;
        private Label label21;
        private TextBox textBox18;
        private Label label22;
        private Label lblMantenimientoInfo;
        private TextBox textBox19;
        private Panel panel4;
        private Button btnCrearMantenimiento;
        private Button btnEditarMantenimiento;
        private Label lblCodigoMantenimiento;
        private Label lblMantenimientoTitle;
        private Button btnBuscarMantenimiento;
        private TextBox txtCodigoMantenimiento;
        private DataGridView dataGridViewClientes;
        private DateTimePicker dateTimePicker2;
    }
}