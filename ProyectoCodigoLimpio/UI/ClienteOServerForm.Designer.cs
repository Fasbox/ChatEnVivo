namespace ProyectoCodigoLimpioClient.Interfaces
{
    partial class ClienteOServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteOServerForm));
            this.buttonIrServidor = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.labelElegir = new System.Windows.Forms.Label();
            this.labelHola = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIrServidor
            // 
            this.buttonIrServidor.BackColor = System.Drawing.Color.White;
            this.buttonIrServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIrServidor.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIrServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.buttonIrServidor.Location = new System.Drawing.Point(35, 173);
            this.buttonIrServidor.Name = "buttonIrServidor";
            this.buttonIrServidor.Size = new System.Drawing.Size(169, 36);
            this.buttonIrServidor.TabIndex = 20;
            this.buttonIrServidor.Text = "SERVIDOR";
            this.buttonIrServidor.UseVisualStyleBackColor = false;
            this.buttonIrServidor.Click += new System.EventHandler(this.buttonIrServidor_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(253, 173);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(169, 36);
            this.buttonCliente.TabIndex = 21;
            this.buttonCliente.Text = "CLIENTE";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // labelElegir
            // 
            this.labelElegir.AutoSize = true;
            this.labelElegir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelElegir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelElegir.Location = new System.Drawing.Point(95, 110);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(266, 34);
            this.labelElegir.TabIndex = 19;
            this.labelElegir.Text = "Antes de comenzar, por favor indícanos si\r\nvas a ser \"Servidor\" o \"Cliente\"\r\n";
            this.labelElegir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHola
            // 
            this.labelHola.AutoSize = true;
            this.labelHola.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHola.Location = new System.Drawing.Point(188, 14);
            this.labelHola.Name = "labelHola";
            this.labelHola.Size = new System.Drawing.Size(80, 27);
            this.labelHola.TabIndex = 18;
            this.labelHola.Text = "¡Hola!";
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenido.Location = new System.Drawing.Point(93, 54);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(270, 27);
            this.labelBienvenido.TabIndex = 22;
            this.labelBienvenido.Text = "Bienvenido a Chubox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoCodigoLimpioClient.Properties.Resources.logo_size;
            this.pictureBox1.Location = new System.Drawing.Point(176, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(398, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 32);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ClienteOServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 294);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.buttonIrServidor);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.labelElegir);
            this.Controls.Add(this.labelHola);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteOServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuBox";
            this.Load += new System.EventHandler(this.ClienteOServerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonIrServidor;
        private Button buttonCliente;
        private Label labelElegir;
        private Label labelHola;
        private Label labelBienvenido;
        private PictureBox pictureBox1;
        private Button exitButton;
    }
}