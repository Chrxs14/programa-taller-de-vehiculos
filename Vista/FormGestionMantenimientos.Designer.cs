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
            btnEnviar = new Button();
            label26 = new Label();
            label25 = new Label();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            label22 = new Label();
            lblMantenimientoInfo = new Label();
            panel4 = new Panel();
            txtTrabajosRealizados = new TextBox();
            label1 = new Label();
            clbServicios = new CheckedListBox();
            cbEsCorrectivo = new CheckBox();
            cmbVehiculo = new ComboBox();
            cmbMecanico = new ComboBox();
            cmbCliente = new ComboBox();
            txtDiagnostico = new TextBox();
            dtbFechaMantenimiento = new DateTimePicker();
            lblCodigoMantenimiento = new Label();
            lblMantenimientoTitle = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            dgvMantenimientos = new DataGridView();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(24, 576);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(427, 49);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
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
            panel4.Controls.Add(txtTrabajosRealizados);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(clbServicios);
            panel4.Controls.Add(cbEsCorrectivo);
            panel4.Controls.Add(cmbVehiculo);
            panel4.Controls.Add(cmbMecanico);
            panel4.Controls.Add(cmbCliente);
            panel4.Controls.Add(txtDiagnostico);
            panel4.Controls.Add(dtbFechaMantenimiento);
            panel4.Controls.Add(btnEnviar);
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
            // txtTrabajosRealizados
            // 
            txtTrabajosRealizados.Location = new Point(175, 489);
            txtTrabajosRealizados.Multiline = true;
            txtTrabajosRealizados.Name = "txtTrabajosRealizados";
            txtTrabajosRealizados.Size = new Size(276, 37);
            txtTrabajosRealizados.TabIndex = 31;
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
            // clbServicios
            // 
            clbServicios.FormattingEnabled = true;
            clbServicios.Location = new Point(175, 387);
            clbServicios.Name = "clbServicios";
            clbServicios.Size = new Size(276, 76);
            clbServicios.TabIndex = 29;
            // 
            // cbEsCorrectivo
            // 
            cbEsCorrectivo.AutoSize = true;
            cbEsCorrectivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbEsCorrectivo.ForeColor = SystemColors.ButtonHighlight;
            cbEsCorrectivo.Location = new Point(175, 532);
            cbEsCorrectivo.Name = "cbEsCorrectivo";
            cbEsCorrectivo.Size = new Size(99, 23);
            cbEsCorrectivo.TabIndex = 28;
            cbEsCorrectivo.Text = "Correctivo";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(175, 192);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(276, 23);
            cmbVehiculo.TabIndex = 27;
            // 
            // cmbMecanico
            // 
            cmbMecanico.FormattingEnabled = true;
            cmbMecanico.Location = new Point(175, 153);
            cmbMecanico.Name = "cmbMecanico";
            cmbMecanico.Size = new Size(276, 23);
            cmbMecanico.TabIndex = 26;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(175, 113);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(276, 23);
            cmbCliente.TabIndex = 25;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(175, 230);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(276, 72);
            txtDiagnostico.TabIndex = 24;
            // 
            // dtbFechaMantenimiento
            // 
            dtbFechaMantenimiento.Anchor = AnchorStyles.None;
            dtbFechaMantenimiento.Location = new Point(175, 333);
            dtbFechaMantenimiento.Name = "dtbFechaMantenimiento";
            dtbFechaMantenimiento.Size = new Size(276, 23);
            dtbFechaMantenimiento.TabIndex = 23;
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(264, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(116, 107);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(142, 23);
            txtBuscar.TabIndex = 19;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // dgvMantenimientos
            // 
            dgvMantenimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMantenimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMantenimientos.BackgroundColor = Color.White;
            dgvMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientos.Location = new Point(29, 148);
            dgvMantenimientos.Name = "dgvMantenimientos";
            dgvMantenimientos.ShowEditingIcon = false;
            dgvMantenimientos.Size = new Size(628, 378);
            dgvMantenimientos.TabIndex = 18;
            dgvMantenimientos.CellClick += dgvMantenimientos_CellClick;
            // 
            // FormGestionMantenimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(1159, 691);
            Controls.Add(lblCodigoMantenimiento);
            Controls.Add(lblMantenimientoTitle);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvMantenimientos);
            Controls.Add(panel4);
            Name = "FormGestionMantenimientos";
            Text = "Gestion de Mantenimientos";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
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
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvMantenimientos;
        private DateTimePicker dtbFechaMantenimiento;
        private ComboBox cmbVehiculo;
        private ComboBox cmbMecanico;
        private ComboBox cmbCliente;
        private TextBox txtDiagnostico;
        private CheckBox cbEsCorrectivo;
        private CheckedListBox clbServicios;
        private TextBox txtTrabajosRealizados;
        private Label label1;
    }
}