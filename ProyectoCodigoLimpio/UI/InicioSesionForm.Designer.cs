namespace ProyectoCodigoLimpioClient.Interfaces
{
    partial class InicioSesionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionForm));
            this.buttonIrAlRegistro = new System.Windows.Forms.Button();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.checkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelYaTienesCuenta = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelComencemos = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIrAlRegistro
            // 
            this.buttonIrAlRegistro.BackColor = System.Drawing.Color.White;
            this.buttonIrAlRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIrAlRegistro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIrAlRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.buttonIrAlRegistro.Location = new System.Drawing.Point(30, 446);
            this.buttonIrAlRegistro.Name = "buttonIrAlRegistro";
            this.buttonIrAlRegistro.Size = new System.Drawing.Size(224, 36);
            this.buttonIrAlRegistro.TabIndex = 16;
            this.buttonIrAlRegistro.Text = "REGISTRARSE";
            this.buttonIrAlRegistro.UseVisualStyleBackColor = false;
            this.buttonIrAlRegistro.Click += new System.EventHandler(this.buttonIrAlRegistro_Click);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSesion.Location = new System.Drawing.Point(30, 375);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(224, 36);
            this.buttonIniciarSesion.TabIndex = 17;
            this.buttonIniciarSesion.Text = "INICIAR SESIÓN";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // checkBoxMostrarContraseña
            // 
            this.checkBoxMostrarContraseña.AutoSize = true;
            this.checkBoxMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMostrarContraseña.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMostrarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBoxMostrarContraseña.Location = new System.Drawing.Point(109, 335);
            this.checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            this.checkBoxMostrarContraseña.Size = new System.Drawing.Size(145, 21);
            this.checkBoxMostrarContraseña.TabIndex = 15;
            this.checkBoxMostrarContraseña.Text = "Mostrar Contraseña";
            this.checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContraseña.CheckedChanged += new System.EventHandler(this.checkBoxMostrarContraseña_CheckedChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContraseña.Location = new System.Drawing.Point(30, 290);
            this.textBoxContraseña.Multiline = true;
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '•';
            this.textBoxContraseña.Size = new System.Drawing.Size(224, 28);
            this.textBoxContraseña.TabIndex = 13;
            // 
            // labelYaTienesCuenta
            // 
            this.labelYaTienesCuenta.AutoSize = true;
            this.labelYaTienesCuenta.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYaTienesCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelYaTienesCuenta.Location = new System.Drawing.Point(67, 426);
            this.labelYaTienesCuenta.Name = "labelYaTienesCuenta";
            this.labelYaTienesCuenta.Size = new System.Drawing.Size(151, 17);
            this.labelYaTienesCuenta.TabIndex = 9;
            this.labelYaTienesCuenta.Text = "¿No tienes una cuenta?";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelContraseña.Location = new System.Drawing.Point(30, 266);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(96, 21);
            this.labelContraseña.TabIndex = 10;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(30, 226);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(224, 28);
            this.textBoxUsername.TabIndex = 14;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelUsername.Location = new System.Drawing.Point(30, 202);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProyectoCodigoLimpioClient.Properties.Resources.logo_size;
            this.pictureBoxLogo.Location = new System.Drawing.Point(71, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 115);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelComencemos
            // 
            this.labelComencemos.AutoSize = true;
            this.labelComencemos.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelComencemos.Location = new System.Drawing.Point(30, 157);
            this.labelComencemos.Name = "labelComencemos";
            this.labelComencemos.Size = new System.Drawing.Size(100, 27);
            this.labelComencemos.TabIndex = 6;
            this.labelComencemos.Text = "Ingresa";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(227, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 32);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonIrAlRegistro);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.checkBoxMostrarContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelYaTienesCuenta);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelComencemos);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuBox";
            this.Load += new System.EventHandler(this.InicioSesionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonIrAlRegistro;
        private Button buttonIniciarSesion;
        private CheckBox checkBoxMostrarContraseña;
        private TextBox textBoxContraseña;
        private Label labelYaTienesCuenta;
        private Label labelContraseña;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private PictureBox pictureBoxLogo;
        private Label labelComencemos;
        private Button exitButton;
    }
}