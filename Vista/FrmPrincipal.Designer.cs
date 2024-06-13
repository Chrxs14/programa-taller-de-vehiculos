namespace POE_proyecto.Vista
{
    partial class FrmPrincipal
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
            btnCliente = new Button();
            btnInfoProyecto = new Button();
            btnMantenimiento = new Button();
            btnMecanico = new Button();
            btnServicio = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(56, 122);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(229, 130);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnInfoProyecto
            // 
            btnInfoProyecto.Location = new Point(344, 324);
            btnInfoProyecto.Name = "btnInfoProyecto";
            btnInfoProyecto.Size = new Size(229, 130);
            btnInfoProyecto.TabIndex = 1;
            btnInfoProyecto.Text = "Información del proyecto";
            btnInfoProyecto.UseVisualStyleBackColor = true;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.Location = new Point(56, 324);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(229, 130);
            btnMantenimiento.TabIndex = 2;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnMecanico
            // 
            btnMecanico.Location = new Point(344, 122);
            btnMecanico.Name = "btnMecanico";
            btnMecanico.Size = new Size(229, 130);
            btnMecanico.TabIndex = 3;
            btnMecanico.Text = "Mecánico";
            btnMecanico.UseVisualStyleBackColor = true;
            // 
            // btnServicio
            // 
            btnServicio.Location = new Point(618, 122);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(229, 130);
            btnServicio.TabIndex = 4;
            btnServicio.Text = "Servicio";
            btnServicio.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnServicio);
            Controls.Add(btnMecanico);
            Controls.Add(btnMantenimiento);
            Controls.Add(btnInfoProyecto);
            Controls.Add(btnCliente);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnInfoProyecto;
        private Button btnMantenimiento;
        private Button btnMecanico;
        private Button btnServicio;
    }
}