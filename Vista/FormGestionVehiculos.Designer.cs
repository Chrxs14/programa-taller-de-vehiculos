namespace POE_proyecto.Vista
{
    partial class FormGestionVehiculos
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
            label18 = new Label();
            txtKilometraje = new TextBox();
            label19 = new Label();
            txtAnio = new TextBox();
            label20 = new Label();
            txtModelo = new TextBox();
            label22 = new Label();
            lblVehiculoInfo = new Label();
            lblPlacaVehiculo = new Label();
            lblVehiculosTitle = new Label();
            btnBuscar = new Button();
            txtSearchByPlaca = new TextBox();
            dgvVehiculos = new DataGridView();
            txtMarca = new TextBox();
            panel4 = new Panel();
            label21 = new Label();
            txtPlaca = new TextBox();
            label1 = new Label();
            txtSearchByMarca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(24, 480);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(396, 49);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(24, 269);
            label18.Name = "label18";
            label18.Size = new Size(127, 28);
            label18.TabIndex = 15;
            label18.Text = "Kilometraje:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(175, 274);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(245, 23);
            txtKilometraje.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(24, 233);
            label19.Name = "label19";
            label19.Size = new Size(55, 28);
            label19.TabIndex = 13;
            label19.Text = "Año:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(175, 237);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(245, 23);
            txtAnio.TabIndex = 12;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(24, 194);
            label20.Name = "label20";
            label20.Size = new Size(89, 28);
            label20.TabIndex = 11;
            label20.Text = "Modelo:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(175, 199);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(245, 23);
            txtModelo.TabIndex = 10;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label22.ForeColor = SystemColors.Control;
            label22.Location = new Point(24, 157);
            label22.Name = "label22";
            label22.Size = new Size(76, 28);
            label22.TabIndex = 7;
            label22.Text = "Marca:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVehiculoInfo
            // 
            lblVehiculoInfo.AutoSize = true;
            lblVehiculoInfo.BackColor = Color.FromArgb(25, 30, 70);
            lblVehiculoInfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblVehiculoInfo.ForeColor = SystemColors.Control;
            lblVehiculoInfo.Location = new Point(24, 59);
            lblVehiculoInfo.Name = "lblVehiculoInfo";
            lblVehiculoInfo.Size = new Size(337, 37);
            lblVehiculoInfo.TabIndex = 6;
            lblVehiculoInfo.Text = "Información del Vehiculo";
            // 
            // lblPlacaVehiculo
            // 
            lblPlacaVehiculo.AutoSize = true;
            lblPlacaVehiculo.BackColor = Color.FromArgb(20, 37, 78);
            lblPlacaVehiculo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPlacaVehiculo.ForeColor = SystemColors.Control;
            lblPlacaVehiculo.Location = new Point(14, 102);
            lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            lblPlacaVehiculo.Size = new Size(67, 28);
            lblPlacaVehiculo.TabIndex = 30;
            lblPlacaVehiculo.Text = "Placa:";
            lblPlacaVehiculo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVehiculosTitle
            // 
            lblVehiculosTitle.AutoSize = true;
            lblVehiculosTitle.BackColor = Color.FromArgb(20, 37, 78);
            lblVehiculosTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblVehiculosTitle.ForeColor = SystemColors.Control;
            lblVehiculosTitle.Location = new Point(14, 50);
            lblVehiculosTitle.Name = "lblVehiculosTitle";
            lblVehiculosTitle.Size = new Size(278, 37);
            lblVehiculosTitle.TabIndex = 29;
            lblVehiculosTitle.Text = "Listado de Vehiculos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(520, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtSearchByPlaca
            // 
            txtSearchByPlaca.Location = new Point(101, 107);
            txtSearchByPlaca.Name = "txtSearchByPlaca";
            txtSearchByPlaca.Size = new Size(142, 23);
            txtSearchByPlaca.TabIndex = 27;
            txtSearchByPlaca.KeyDown += txtSearchByPlaca_KeyDown;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.BackgroundColor = Color.White;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(14, 148);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ShowEditingIcon = false;
            dgvVehiculos.Size = new Size(626, 354);
            dgvVehiculos.TabIndex = 26;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(175, 162);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(245, 23);
            txtMarca.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 30, 70);
            panel4.Controls.Add(btnEnviar);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(txtKilometraje);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(txtAnio);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(txtModelo);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(txtPlaca);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(lblVehiculoInfo);
            panel4.Controls.Add(txtMarca);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(679, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 556);
            panel4.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(24, 121);
            label21.Name = "label21";
            label21.Size = new Size(67, 28);
            label21.TabIndex = 9;
            label21.Text = "Placa:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(175, 126);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(245, 23);
            txtPlaca.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(20, 37, 78);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(262, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 32;
            label1.Text = "Marca:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchByMarca
            // 
            txtSearchByMarca.Location = new Point(345, 107);
            txtSearchByMarca.Name = "txtSearchByMarca";
            txtSearchByMarca.Size = new Size(142, 23);
            txtSearchByMarca.TabIndex = 31;
            txtSearchByMarca.KeyDown += txtSearchByMarca_KeyDown;
            // 
            // FormGestionVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(1159, 556);
            Controls.Add(label1);
            Controls.Add(txtSearchByMarca);
            Controls.Add(lblPlacaVehiculo);
            Controls.Add(lblVehiculosTitle);
            Controls.Add(btnBuscar);
            Controls.Add(txtSearchByPlaca);
            Controls.Add(dgvVehiculos);
            Controls.Add(panel4);
            Name = "FormGestionVehiculos";
            Text = "Gestion de Vehiculos";
            Load += FormGestionVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnviar;
        private Label label26;
        private TextBox txtKilometraje;
        private Label label25;
        private Label label24;
        private TextBox txtAnio;
        private Label label18;
        private TextBox txtModelo;
        private Label label19;
        private TextBox textBox16;
        private Label label20;
        private TextBox textBox17;
        private TextBox textBox18;
        private Label label22;
        private Label lblVehiculoInfo;
        private Label lblPlacaVehiculo;
        private Label lblVehiculosTitle;
        private Button btnBuscar;
        private TextBox txtSearchByPlaca;
        private DataGridView dgvVehiculos;
        private TextBox txtMarca;
        private Panel panel4;
        private Label label21;
        private TextBox txtPlaca;
        private Label label1;
        private TextBox txtSearchByMarca;
    }
}