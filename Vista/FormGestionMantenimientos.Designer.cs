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
            lblGestionMantenimientos = new Label();
            SuspendLayout();
            // 
            // lblGestionMantenimientos
            // 
            lblGestionMantenimientos.AutoSize = true;
            lblGestionMantenimientos.Font = new Font("Segoe UI", 40F);
            lblGestionMantenimientos.ForeColor = Color.White;
            lblGestionMantenimientos.Location = new Point(125, 189);
            lblGestionMantenimientos.Name = "lblGestionMantenimientos";
            lblGestionMantenimientos.Size = new Size(615, 72);
            lblGestionMantenimientos.TabIndex = 2;
            lblGestionMantenimientos.Text = "Gestion Mantenimientos";
            // 
            // FormGestionMantenimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(800, 450);
            Controls.Add(lblGestionMantenimientos);
            Name = "FormGestionMantenimientos";
            Text = "Gestion de Mantenimientos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestionMantenimientos;
    }
}