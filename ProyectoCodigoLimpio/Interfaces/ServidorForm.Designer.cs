namespace ProyectoCodigoLimpioClient.Interfaces
{
    partial class ServidorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServidorForm));
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCrearServer = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCrear.ForeColor = System.Drawing.Color.White;
            this.buttonCrear.Location = new System.Drawing.Point(30, 383);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(224, 36);
            this.buttonCrear.TabIndex = 24;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxPuerto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPuerto.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPuerto.Location = new System.Drawing.Point(30, 298);
            this.textBoxPuerto.Multiline = true;
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(224, 28);
            this.textBoxPuerto.TabIndex = 22;
            this.textBoxPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPuerto_KeyPress);
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPuerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelPuerto.Location = new System.Drawing.Point(30, 274);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(147, 21);
            this.labelPuerto.TabIndex = 20;
            this.labelPuerto.Text = "Puerto de Entrada";
            // 
            // textBoxIp
            // 
            this.textBoxIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIp.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIp.Location = new System.Drawing.Point(30, 234);
            this.textBoxIp.Multiline = true;
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(224, 28);
            this.textBoxIp.TabIndex = 23;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelIp.Location = new System.Drawing.Point(30, 210);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(122, 21);
            this.labelIp.TabIndex = 21;
            this.labelIp.Text = "Ip del Servidor";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProyectoCodigoLimpioClient.Properties.Resources.logo_size;
            this.pictureBoxLogo.Location = new System.Drawing.Point(71, 25);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 115);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 19;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCrearServer
            // 
            this.labelCrearServer.AutoSize = true;
            this.labelCrearServer.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCrearServer.Location = new System.Drawing.Point(30, 165);
            this.labelCrearServer.Name = "labelCrearServer";
            this.labelCrearServer.Size = new System.Drawing.Size(215, 27);
            this.labelCrearServer.TabIndex = 18;
            this.labelCrearServer.Text = "Crea tu Servidor";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Location = new System.Drawing.Point(-1, -1);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(286, 29);
            this.headerPanel.TabIndex = 25;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(228, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 32);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ServidorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxPuerto);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelCrearServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServidorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCrear;
        private TextBox textBoxPuerto;
        private Label labelPuerto;
        private TextBox textBoxIp;
        private Label labelIp;
        private PictureBox pictureBoxLogo;
        private Label labelCrearServer;
        private Panel headerPanel;
        private Button exitButton;
    }
}