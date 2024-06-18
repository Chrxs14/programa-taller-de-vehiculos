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
            panelMenu = new Panel();
            reportBtn = new FontAwesome.Sharp.IconButton();
            maintenanceManageBtn = new FontAwesome.Sharp.IconButton();
            vehicleManageBtn = new FontAwesome.Sharp.IconButton();
            clientManageBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            titlePageLabel = new Label();
            iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(36, 44, 69);
            panelMenu.Controls.Add(reportBtn);
            panelMenu.Controls.Add(maintenanceManageBtn);
            panelMenu.Controls.Add(vehicleManageBtn);
            panelMenu.Controls.Add(clientManageBtn);
            panelMenu.Controls.Add(homeBtn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 755);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // reportBtn
            // 
            reportBtn.Dock = DockStyle.Top;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reportBtn.ForeColor = SystemColors.ButtonFace;
            reportBtn.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            reportBtn.IconColor = Color.White;
            reportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            reportBtn.IconSize = 30;
            reportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportBtn.Location = new Point(0, 380);
            reportBtn.Name = "reportBtn";
            reportBtn.Padding = new Padding(10, 0, 20, 0);
            reportBtn.Size = new Size(220, 60);
            reportBtn.TabIndex = 5;
            reportBtn.Text = "Reportes";
            reportBtn.TextAlign = ContentAlignment.MiddleLeft;
            reportBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // maintenanceManageBtn
            // 
            maintenanceManageBtn.Dock = DockStyle.Top;
            maintenanceManageBtn.FlatAppearance.BorderSize = 0;
            maintenanceManageBtn.FlatStyle = FlatStyle.Flat;
            maintenanceManageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            maintenanceManageBtn.ForeColor = SystemColors.ButtonFace;
            maintenanceManageBtn.IconChar = FontAwesome.Sharp.IconChar.CarBattery;
            maintenanceManageBtn.IconColor = Color.White;
            maintenanceManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maintenanceManageBtn.IconSize = 30;
            maintenanceManageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            maintenanceManageBtn.Location = new Point(0, 320);
            maintenanceManageBtn.Name = "maintenanceManageBtn";
            maintenanceManageBtn.Padding = new Padding(10, 0, 20, 0);
            maintenanceManageBtn.Size = new Size(220, 60);
            maintenanceManageBtn.TabIndex = 4;
            maintenanceManageBtn.Text = "Gestión de Mantenimientos";
            maintenanceManageBtn.TextAlign = ContentAlignment.MiddleLeft;
            maintenanceManageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            maintenanceManageBtn.UseVisualStyleBackColor = true;
            maintenanceManageBtn.Click += maintenanceManageBtn_Click;
            // 
            // vehicleManageBtn
            // 
            vehicleManageBtn.Dock = DockStyle.Top;
            vehicleManageBtn.FlatAppearance.BorderSize = 0;
            vehicleManageBtn.FlatStyle = FlatStyle.Flat;
            vehicleManageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            vehicleManageBtn.ForeColor = SystemColors.ButtonFace;
            vehicleManageBtn.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            vehicleManageBtn.IconColor = Color.White;
            vehicleManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            vehicleManageBtn.IconSize = 30;
            vehicleManageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            vehicleManageBtn.Location = new Point(0, 260);
            vehicleManageBtn.Name = "vehicleManageBtn";
            vehicleManageBtn.Padding = new Padding(10, 0, 20, 0);
            vehicleManageBtn.Size = new Size(220, 60);
            vehicleManageBtn.TabIndex = 3;
            vehicleManageBtn.Text = "Gestion de Vehiculos";
            vehicleManageBtn.TextAlign = ContentAlignment.MiddleLeft;
            vehicleManageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            vehicleManageBtn.UseVisualStyleBackColor = true;
            vehicleManageBtn.Click += vehicleManageBtn_Click;
            // 
            // clientManageBtn
            // 
            clientManageBtn.Dock = DockStyle.Top;
            clientManageBtn.FlatAppearance.BorderSize = 0;
            clientManageBtn.FlatStyle = FlatStyle.Flat;
            clientManageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            clientManageBtn.ForeColor = SystemColors.ButtonFace;
            clientManageBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            clientManageBtn.IconColor = Color.White;
            clientManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clientManageBtn.IconSize = 30;
            clientManageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            clientManageBtn.Location = new Point(0, 200);
            clientManageBtn.Name = "clientManageBtn";
            clientManageBtn.Padding = new Padding(10, 0, 20, 0);
            clientManageBtn.Size = new Size(220, 60);
            clientManageBtn.TabIndex = 2;
            clientManageBtn.Text = "Gestion de Clientes";
            clientManageBtn.TextAlign = ContentAlignment.MiddleLeft;
            clientManageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            clientManageBtn.UseVisualStyleBackColor = true;
            clientManageBtn.Click += iconButton1_Click_2;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Top;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            homeBtn.ForeColor = Color.White;
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            homeBtn.IconColor = Color.White;
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.IconSize = 30;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 140);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(10, 0, 20, 0);
            homeBtn.Size = new Size(220, 60);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "Home";
            homeBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image__1_;
            pictureBox1.Location = new Point(31, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 29, 46);
            panelTitleBar.Controls.Add(titlePageLabel);
            panelTitleBar.Controls.Add(iconChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1175, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // titlePageLabel
            // 
            titlePageLabel.AutoSize = true;
            titlePageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titlePageLabel.ForeColor = Color.White;
            titlePageLabel.Location = new Point(60, 29);
            titlePageLabel.Name = "titlePageLabel";
            titlePageLabel.Size = new Size(102, 21);
            titlePageLabel.TabIndex = 1;
            titlePageLabel.Text = "Bienvenido!";
            // 
            // iconChildForm
            // 
            iconChildForm.BackColor = Color.FromArgb(24, 29, 46);
            iconChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            iconChildForm.IconColor = Color.White;
            iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconChildForm.Location = new Point(25, 23);
            iconChildForm.Name = "iconChildForm";
            iconChildForm.Size = new Size(32, 32);
            iconChildForm.TabIndex = 0;
            iconChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(20, 37, 78);
            panelDesktop.Controls.Add(label1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1175, 680);
            panelDesktop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(444, 233);
            label1.Name = "label1";
            label1.Size = new Size(295, 72);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.Click += label1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 755);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios de Mantenimiento";
            Load += FrmPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton reportBtn;
        private FontAwesome.Sharp.IconButton maintenanceManageBtn;
        private FontAwesome.Sharp.IconButton vehicleManageBtn;
        private FontAwesome.Sharp.IconButton clientManageBtn;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private Label titlePageLabel;
        private Panel panelDesktop;
        private Label label1;
    }
}