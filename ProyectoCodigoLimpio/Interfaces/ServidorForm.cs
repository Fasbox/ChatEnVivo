using ProyectoCodigoLimpioClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoCodigoLimpioClient.Interfaces
{
    public partial class ServidorForm : Form
    {
        public ServidorForm()
        {
            InitializeComponent();
        }


        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (textBoxIp.Text == "" || textBoxPuerto.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos, por favor llena los datos que faltan", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new ServidorForm().Show();
                this.Close();
            }
            else
            {
                Thread t = new Thread(() => Application.Run(new InicioSesionForm()));
                t.Start();

                this.Hide();

                string ip = textBoxIp.Text;
                int port = int.Parse(textBoxPuerto.Text);

                var servidor = new ServerProgram(ip, port);


            }
            

        }
        int mouseX = 0;
        int mouseY = 0;
        int mouseinX = 0;
        int mouseinY = 0;
        bool mouseDown;
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textBoxPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
