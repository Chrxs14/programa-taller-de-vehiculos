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
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(301, 198);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(240, 150);
            dataGridViewClientes.TabIndex = 0;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(275, 122);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(100, 23);
            textBoxBuscarCliente.TabIndex = 1;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Location = new Point(432, 124);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(75, 23);
            buttonBuscarCliente.TabIndex = 2;
            buttonBuscarCliente.Text = "button1";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 37, 78);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(dataGridViewClientes);
            Name = "FormGestionClientes";
            Text = "Gestion de Clientes";
            TopMost = true;
            Load += FormGestionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private TextBox textBoxBuscarCliente;
        private Button buttonBuscarCliente;
    }
}