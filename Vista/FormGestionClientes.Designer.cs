namespace POE_proyecto.Vista
{
    partial class FormGestionClientes
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
            dataGridViewClientes = new DataGridView();
            textBoxBuscarCliente = new TextBox();
            buttonBuscarCliente = new Button();
            lblClientesTitle = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnEnviarDatosCliente = new Button();
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
            label23 = new Label();
            textBox19 = new TextBox();
            label12 = new Label();
            textBox10 = new TextBox();
            label13 = new Label();
            textBox11 = new TextBox();
            label14 = new Label();
            textBox12 = new TextBox();
            label15 = new Label();
            textBox13 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textBox14 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            lblClienteInfo = new Label();
            textBox1 = new TextBox();
            btnEditarCliente = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(23, 136);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ShowEditingIcon = false;
            dataGridViewClientes.Size = new Size(626, 354);
            dataGridViewClientes.TabIndex = 0;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(110, 95);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(142, 23);
            textBoxBuscarCliente.TabIndex = 1;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Location = new Point(258, 95);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(75, 23);
            buttonBuscarCliente.TabIndex = 2;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // lblClientesTitle
            // 
            lblClientesTitle.AutoSize = true;
            lblClientesTitle.BackColor = Color.FromArgb(20, 37, 78);
            lblClientesTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblClientesTitle.ForeColor = SystemColors.Control;
            lblClientesTitle.Location = new Point(23, 38);
            lblClientesTitle.Name = "lblClientesTitle";
            lblClientesTitle.Size = new Size(259, 37);
            lblClientesTitle.TabIndex = 3;
            lblClientesTitle.Text = "Listado de Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(20, 37, 78);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(23, 90);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 4;
            label1.Text = "Cedula:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 30, 70);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblClienteInfo);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(676, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 553);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 30, 70);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox8);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(33, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 553);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 30, 70);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(textBox11);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBox12);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(textBox13);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(textBox14);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(-20, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 553);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 30, 70);
            panel4.Controls.Add(btnEnviarDatosCliente);
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
            panel4.Controls.Add(label23);
            panel4.Controls.Add(textBox19);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(-10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 553);
            panel4.TabIndex = 16;
            // 
            // btnEnviarDatosCliente
            // 
            btnEnviarDatosCliente.Location = new Point(24, 480);
            btnEnviarDatosCliente.Name = "btnEnviarDatosCliente";
            btnEnviarDatosCliente.Size = new Size(396, 49);
            btnEnviarDatosCliente.TabIndex = 8;
            btnEnviarDatosCliente.Text = "Enviar";
            btnEnviarDatosCliente.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 361);
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
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(25, 30, 70);
            label23.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label23.ForeColor = SystemColors.Control;
            label23.Location = new Point(24, 59);
            label23.Name = "label23";
            label23.Size = new Size(318, 37);
            label23.TabIndex = 6;
            label23.Text = "Información del Cliente";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(175, 162);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(245, 23);
            textBox19.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(66, 298);
            label12.Name = "label12";
            label12.Size = new Size(80, 28);
            label12.TabIndex = 15;
            label12.Text = "Correo:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(177, 298);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(142, 23);
            textBox10.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(66, 270);
            label13.Name = "label13";
            label13.Size = new Size(107, 28);
            label13.TabIndex = 13;
            label13.Text = "Dirección:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(177, 270);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(142, 23);
            textBox11.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(66, 238);
            label14.Name = "label14";
            label14.Size = new Size(105, 28);
            label14.TabIndex = 11;
            label14.Text = "Apellidos:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(177, 241);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(142, 23);
            textBox12.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(66, 176);
            label15.Name = "label15";
            label15.Size = new Size(81, 28);
            label15.TabIndex = 9;
            label15.Text = "Cedula:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(177, 184);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(142, 23);
            textBox13.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(66, 207);
            label16.Name = "label16";
            label16.Size = new Size(103, 28);
            label16.TabIndex = 7;
            label16.Text = "Nombres:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(25, 30, 70);
            label17.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(66, 59);
            label17.Name = "label17";
            label17.Size = new Size(318, 37);
            label17.TabIndex = 6;
            label17.Text = "Información del Cliente";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(177, 213);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(142, 23);
            textBox14.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(66, 298);
            label11.Name = "label11";
            label11.Size = new Size(80, 28);
            label11.TabIndex = 15;
            label11.Text = "Correo:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(177, 298);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(142, 23);
            textBox9.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(66, 270);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 13;
            label6.Text = "Dirección:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(177, 270);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(66, 238);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 11;
            label7.Text = "Apellidos:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(177, 241);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(66, 176);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 9;
            label8.Text = "Cedula:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(177, 184);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(142, 23);
            textBox7.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(66, 207);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 7;
            label9.Text = "Nombres:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(25, 30, 70);
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(66, 59);
            label10.Name = "label10";
            label10.Size = new Size(318, 37);
            label10.TabIndex = 6;
            label10.Text = "Información del Cliente";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(177, 213);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(142, 23);
            textBox8.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(66, 267);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 13;
            label5.Text = "Dirección:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(66, 238);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 11;
            label4.Text = "Apellidos:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(66, 176);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 9;
            label3.Text = "Cedula:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(66, 207);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 7;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClienteInfo
            // 
            lblClienteInfo.AutoSize = true;
            lblClienteInfo.BackColor = Color.FromArgb(25, 30, 70);
            lblClienteInfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblClienteInfo.ForeColor = SystemColors.Control;
            lblClienteInfo.Location = new Point(66, 59);
            lblClienteInfo.Name = "lblClienteInfo";
            lblClienteInfo.Size = new Size(318, 37);
            lblClienteInfo.TabIndex = 6;
            lblClienteInfo.Text = "Información del Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 6;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(339, 95);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(75, 23);
            btnEditarCliente.TabIndex = 6;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(420, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(1159, 553);
            Controls.Add(button2);
            Controls.Add(btnEditarCliente);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblClientesTitle);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(dataGridViewClientes);
            Name = "FormGestionClientes";
            Text = "Gestion de Clientes";
            TopMost = true;
            TransparencyKey = Color.FromArgb(20, 37, 78);
            Load += FormGestionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private TextBox textBoxBuscarCliente;
        private Button buttonBuscarCliente;
        private Label lblClientesTitle;
        private Label label1;
        private Panel panel1;
        private Label lblClienteInfo;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
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
        private Label label23;
        private TextBox textBox19;
        private Label label12;
        private TextBox textBox10;
        private Label label13;
        private TextBox textBox11;
        private Label label14;
        private TextBox textBox12;
        private Label label15;
        private TextBox textBox13;
        private Label label16;
        private Label label17;
        private TextBox textBox14;
        private Label label11;
        private TextBox textBox9;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private Label label5;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button btnEditarCliente;
        private Button button2;
        private Button btnEnviarDatosCliente;
    }
}