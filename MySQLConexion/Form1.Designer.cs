namespace MySQLConexion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConectar = new Button();
            lblBaseDeDatos = new Label();
            lblHost = new Label();
            lblContrasena = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtHost = new TextBox();
            txtBaseDeDatos = new TextBox();
            lblPuerto = new Label();
            txtPuerto = new TextBox();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConectar.Location = new Point(238, 318);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(134, 45);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblBaseDeDatos
            // 
            lblBaseDeDatos.AutoSize = true;
            lblBaseDeDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseDeDatos.Location = new Point(45, 207);
            lblBaseDeDatos.Name = "lblBaseDeDatos";
            lblBaseDeDatos.Size = new Size(116, 21);
            lblBaseDeDatos.TabIndex = 1;
            lblBaseDeDatos.Text = "Base de Datos";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHost.Location = new Point(116, 162);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(45, 21);
            lblHost.TabIndex = 2;
            lblHost.Text = "Host";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasena.Location = new Point(65, 114);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(96, 21);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(88, 64);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(204, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(168, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(203, 114);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(169, 23);
            txtContrasena.TabIndex = 6;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(204, 162);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(169, 23);
            txtHost.TabIndex = 7;
            // 
            // txtBaseDeDatos
            // 
            txtBaseDeDatos.Location = new Point(203, 207);
            txtBaseDeDatos.Name = "txtBaseDeDatos";
            txtBaseDeDatos.Size = new Size(169, 23);
            txtBaseDeDatos.TabIndex = 8;
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuerto.Location = new Point(100, 259);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(61, 21);
            lblPuerto.TabIndex = 9;
            lblPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(203, 259);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(169, 23);
            txtPuerto.TabIndex = 10;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(398, 64);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(545, 299);
            dgvDatos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 443);
            Controls.Add(dgvDatos);
            Controls.Add(txtPuerto);
            Controls.Add(lblPuerto);
            Controls.Add(txtBaseDeDatos);
            Controls.Add(txtHost);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblHost);
            Controls.Add(lblBaseDeDatos);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Label lblBaseDeDatos;
        private Label lblHost;
        private Label lblContrasena;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtHost;
        private TextBox txtBaseDeDatos;
        private Label lblPuerto;
        private TextBox txtPuerto;
        private DataGridView dgvDatos;
    }
}